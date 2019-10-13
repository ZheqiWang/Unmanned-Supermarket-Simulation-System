(function(){
    var html = document.documentElement,
        meta = document.querySelector('meta[name="viewport"]');
    function init(dpr){
        var vw = html.clientWidth,
            vh = html.clientHeight;
        vw = vw < 320 ? 320 : vw;
        vw = vw > 640 ? 640 : vw;
        var rem = vw / 640 * 20;

        html.setAttribute("data-dpr", dpr);// ��̬д����ʽ
        html.style.fontSize = rem + "px";
        window.vw = vw;
        window.vh = vh;
    }
    init(window.devicePixelRatio || 1);
    window.onresize = function(){
        init(window.devicePixelRatio || 1,true);
    };


    // ��׿����ֹ�û������ֺ�
    if (typeof WeixinJSBridge == "object" && typeof WeixinJSBridge.invoke == "function") {
    ����  handleFontSize();
    } else {
    ����if (document.addEventListener) {
    ��������document.addEventListener("WeixinJSBridgeReady", handleFontSize, false);
    ����} else if (document.attachEvent) {
    ��������document.attachEvent("WeixinJSBridgeReady", handleFontSize);
    ��������document.attachEvent("onWeixinJSBridgeReady", handleFontSize);
    ����}
    }

    function handleFontSize() {
    ����// ������ҳ����ΪĬ�ϴ�С
    ����WeixinJSBridge.invoke("setFontSizeCallback", {
    ����  "fontSize": 0
    ����});

    ����// ��д������ҳ�����С���¼�
    ����WeixinJSBridge.on("menu:setfont", function () {
    ��������WeixinJSBridge.invoke("setFontSizeCallback", {
    ������������"fontSize": 0
    ��������});
    ����});
    }

    var provinceCityFlg = false;
    // -----------ajax����-----------//
    function provinceCityGet(){//���ʡ���������Ƿ񻺴�������
        var provinceCitys = localStorage.getItem("local_provinces");
        if(provinceCitys){
           provinceCitys = JSON.parse(provinceCitys);
           if(provinceCitys.version && parseInt(provinceCitys.version)==8){
               return;
           }
        }
        try{
    ��      var xmlhttp=new XMLHttpRequest();
        ����xmlhttp.open("GET",location.protocol + '//' + location.host + '/we/static/data/provinces.json',true);
        ����xmlhttp.onreadystatechange=getOkGet;//�����¼����յ���Ϣ�˵��ú���
        ����xmlhttp.send();
            function getOkGet(){
            ����if (xmlhttp.readyState==4 && xmlhttp.status==200){
            ��������var d= xmlhttp.responseText;
                    localStorage.setItem("local_provinces",d);
            ��������provinceCityFlg=false;
                }
            }
        }catch(e){
            if(provinceCityFlg){
                return;
            }
            provinceCityFlg=true;
            provinceCityGet();
        }
    }
	//�ж��Ƿ����û�
	var newUsers = localStorage.getItem("local_isNewUser")||{};
	if(!Object.keys(newUsers).length) {
		// û�����û���ʶlocal_isNewUser��ͨ�������ʡ�����ж�
		var local_provinces = localStorage.getItem("local_provinces") || localStorage.getItem("local_provinceCitys");
		// û�����û���ʶlocal_isNewUser��ͨ�������ʡ�����ж�
		if (local_provinces) newUsers.noHint = true;
		else newUsers.noHint = false
		localStorage.setItem("local_isNewUser",JSON.stringify(newUsers));
	}
    provinceCityGet();
})();
