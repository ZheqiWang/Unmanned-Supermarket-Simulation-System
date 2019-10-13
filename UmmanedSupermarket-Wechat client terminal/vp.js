(function(){
    var html = document.documentElement,
        meta = document.querySelector('meta[name="viewport"]');
    function init(dpr){
        var vw = html.clientWidth,
            vh = html.clientHeight;
        vw = vw < 320 ? 320 : vw;
        vw = vw > 640 ? 640 : vw;
        var rem = vw / 640 * 20;

        html.setAttribute("data-dpr", dpr);// 动态写入样式
        html.style.fontSize = rem + "px";
        window.vw = vw;
        window.vh = vh;
    }
    init(window.devicePixelRatio || 1);
    window.onresize = function(){
        init(window.devicePixelRatio || 1,true);
    };


    // 安卓，禁止用户缩放字号
    if (typeof WeixinJSBridge == "object" && typeof WeixinJSBridge.invoke == "function") {
    　　  handleFontSize();
    } else {
    　　if (document.addEventListener) {
    　　　　document.addEventListener("WeixinJSBridgeReady", handleFontSize, false);
    　　} else if (document.attachEvent) {
    　　　　document.attachEvent("WeixinJSBridgeReady", handleFontSize);
    　　　　document.attachEvent("onWeixinJSBridgeReady", handleFontSize);
    　　}
    }

    function handleFontSize() {
    　　// 设置网页字体为默认大小
    　　WeixinJSBridge.invoke("setFontSizeCallback", {
    　　  "fontSize": 0
    　　});

    　　// 重写设置网页字体大小的事件
    　　WeixinJSBridge.on("menu:setfont", function () {
    　　　　WeixinJSBridge.invoke("setFontSizeCallback", {
    　　　　　　"fontSize": 0
    　　　　});
    　　});
    }

    var provinceCityFlg = false;
    // -----------ajax方法-----------//
    function provinceCityGet(){//检查省市区数据是否缓存至本地
        var provinceCitys = localStorage.getItem("local_provinces");
        if(provinceCitys){
           provinceCitys = JSON.parse(provinceCitys);
           if(provinceCitys.version && parseInt(provinceCitys.version)==8){
               return;
           }
        }
        try{
    　      var xmlhttp=new XMLHttpRequest();
        　　xmlhttp.open("GET",location.protocol + '//' + location.host + '/we/static/data/provinces.json',true);
        　　xmlhttp.onreadystatechange=getOkGet;//发送事件后，收到信息了调用函数
        　　xmlhttp.send();
            function getOkGet(){
            　　if (xmlhttp.readyState==4 && xmlhttp.status==200){
            　　　　var d= xmlhttp.responseText;
                    localStorage.setItem("local_provinces",d);
            　　　　provinceCityFlg=false;
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
	//判断是否新用户
	var newUsers = localStorage.getItem("local_isNewUser")||{};
	if(!Object.keys(newUsers).length) {
		// 没有新用户标识local_isNewUser就通过缓存的省市区判断
		var local_provinces = localStorage.getItem("local_provinces") || localStorage.getItem("local_provinceCitys");
		// 没有新用户标识local_isNewUser就通过缓存的省市区判断
		if (local_provinces) newUsers.noHint = true;
		else newUsers.noHint = false
		localStorage.setItem("local_isNewUser",JSON.stringify(newUsers));
	}
    provinceCityGet();
})();
