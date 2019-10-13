<?php
require_once "jssdk.php";
$jssdk = new JSSDK("wx9e02167350e25524", "6c7242296675c22e6cbe3fd084f51db1");
$signPackage = $jssdk->GetSignPackage();
?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport"
          content="width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no">
    <meta name="format-detection" content="telephone=no, email=no">
    <title>W无人超市</title>
    <style>
        body{font-size: 12px;}
        ul li{list-style: none;}
        .track-rcol{width: 750rpx; border: 1px solid #eee;}
        .track-list{margin: 20px; padding-left: 5px; position: relative;}
        .track-list li{position: relative; padding: 9px 0 0 25px; line-height: 18px; border-left: 1px solid #d9d9d9; color: #999;}
        .content-body{display: flex}
        .set-display-block{display: block}
        .date-one{width: 50px;color: #FB0004}
        .date-two{width: 50px;}
        .content-pic{align-items: center; align-content: center;margin-left: 15px;display: flex}
        .content-blank{width: 10px}
        .content-pic-img{width: 20px; height: 20px;}
        .content-line-center{width: 1px;height: 23%;background-color: #767676; position: absolute;bottom: 0px;left: 100px;}
        .content-address{width: 400px;display: flex;align-items: center;color: #FB0004;left:10px;}
        .content-address-two{width: 400px;display: flex;align-items: center;left: 10px;}
        .content-line-center-two{width: 1px;height: 100%;background-color: #767676; position: absolute;top: -1px;left: 100px;}
        .content-line-center-three{width: 1px;height: 42%;background-color: #767676; position: absolute;top: -1px;left: 100px;}
    </style>
    <script src="vp.js" charset="utf-8"></script>
    <link rel="stylesheet" href="swiper.min.css" media="screen" charset="utf-8">
    <link rel="stylesheet" href="queryExp.css" media="screen" charset="utf-8">
    <link rel="stylesheet" type="text/css" href="css/normalize.css" />
    <link rel="stylesheet" type="text/css" href="css/demo.css">
    <link rel='stylesheet' href='css/icon.css' type='text/css'>
    <link rel="stylesheet" href="dist/sidenav.min.css" type="text/css">
</head>
<body class="page-query member-login-page" style={{cursor:'pointer'}}>

<header class="page-title" style={{cursor:'pointer'}}>
    <!--<script data-main="http://ucmp-static.sf-express.com/cx/scripts/query/query.main" src="require.js" charset="utf-8"></script>-->
    <a class="sidenav" data-sidenav data-sidenav-toggle="#sidenav-toggle" >
        <div class="sidenav-brand" onclick="window.location.href='sample.php'">
            无人超市
        </div>

        <div class="sidenav-header" id="showUserInfo" onclick="to()" >
            <!--"window.location.href='login.php'"-->
            个人中心
        </div>
        <div class="sidenav-header" onclick="window.location.href='introduce.html'">
            超市简介
        </div>
        <div class="sidenav-header" onclick="window.location.href='contactus.php'">
            联系我们
        </div>




    </a>
    <a class="my-nav" href="javascript:;" id="sidenav-toggle" id ="show" ></a>



    <h1 class="title">欢迎来到无人超市</h1>
</header>
<section class="form-main" id="query">

    <!--<input id="waybillNoId" type="button" value="请输入要查询的单号" onclick="window.location.href='history.html?from=query'">-->
    <input type="button" value="请扫码查询商品" onclick="">
    <i  class="scan"></i>
</section>


<div class="container">
    <div class="row">
        <div id="slide">
             <div class="hd" style="display:none">
               <ul><li class="on"></li><li class="on"></li><li class="on"></li></ul>
            </div>
            <div class="bd">
                <div class="tempWrap" style="overflow:hidden; position:relative;">
                    <ul style="width: 3840px; position: relative; overflow: hidden; padding: 0px; margin: 0px; transition-duration: 200ms; transform: translateX(-768px);">
                        <li style="display: table-cell; vertical-align: top; width: 768px;">
                            <img src="img/1.jpg" alt="女包">
                        </li>
                        <li style="display: table-cell; vertical-align: top; width: 768px;">
                            <img src="img/2.jpg" alt="女鞋" >
                        </li>
                        <li style="display: table-cell; vertical-align: top; width: 768px;">
                            <img src="img/3.jpg" alt="服装" >
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>

    <script charset="utf-8" src="js/TouchSlide.js"></script>

    <script type="text/javascript">

        TouchSlide({
            slideCell:"#slide",
            titCell:".hd ul", //开启自动分页 autoPage:true ，此时设置 titCell 为导航元素包裹层
            mainCell:".bd ul",
            effect:"left",
            autoPlay:true,//自动播放
            autoPage:true, //自动分页
            switchLoad:"_src" //切换加载，真实图片路径为"_src"
        });
    </script>


<div class="track-rcol">
    <div class="track-list">
        <span class="code" style="font-size:20px"></span><br/>
        <span class="Name" style="font-size:20px"></span><br/>
        <span class="Price" style="font-size:20px"></span><br/>
        <ul id="FileCollection">

        </ul>
    </div>
</div>
    <div >
        <br/>
    <input type="submit" name="submit" value="确认购买" id="buyOK"
           style="font-size:20px;font-family:'黑体';color:#545454;padding:5;width:120;margin:0 auto;border-radius:4px;border:1px solid  #DBDBDB;">
        <br/>
    </div>



<script src="jweixin-1.0.0.js"></script>
<script type="text/javascript" src="jquery.js"></script>
<script src="dist/sidenav.min.js"></script>
<script type="text/javascript">
    
    var openID;
    //var AccessToken;
    
    /*var nickname;
    var sex;
    var address;
    var headimgurl;*/
    
     //点击确认购买按钮
      $("#buyOK").click(function(){
           if ( ComCode==null|| ComName==null|| ComPrice==null )
           {
               alert("您还没有选择商品呦~");
           }
           else
           {
              
                    $.ajax({
                    url:"/test3/php.php",
                    data:{
                        "type":"GetComBuy",
                        "Code":ComCode,
                        "Name":ComName,
                        "Price":ComPrice,
                        "openID":openID
                    },
                    type:"get",
                    success:function(buyresult){
                        var buystaff=$.parseJSON(buyresult);
                        alert(buystaff.msg);
                        //openid必须先点击login.php中的登录按键才能返回
                        
                        
                        
                        },
                    error:function(e,x,th){
                        alert(6666666);
                   	 }
                 });
              
              
           }
      });
    
     /*$("#showUserInfo").click(function(){
         //alert(openID);
         //window.location.href = "http://1.578366017.applinzi.com/test3/login.php?openid=" + openID ";

      });*/
    function   to(){  
        //alert(AccessToken);
        //var  getval =document.getElementById("cc").value;  
        window.location.href="login.php?code="+openID+"&AccessToken="+AccessToken+"&forR";
            //+"&sex="+ sex +"&address="+ address +"&headimgurl="+ headimgurl;  
      }  
    
    wx.config({
        // debug: true,
        appId: '<?php echo $signPackage["appId"];?>',
        timestamp: <?php echo $signPackage["timestamp"];?>,
        nonceStr: '<?php echo $signPackage["nonceStr"];?>',
        signature: '<?php echo $signPackage["signature"];?>',
        jsApiList: [
            'checkJsApi',
            'onMenuShareTimeline',
            'onMenuShareAppMessage',
            'onMenuShareQQ',
            'onMenuShareWeibo',
            'hideMenuItems',
            'showMenuItems',
            'hideAllNonBaseMenuItem',
            'showAllNonBaseMenuItem',
            'translateVoice',
            'startRecord',
            'stopRecord',
            'onRecordEnd',
            'playVoice',
            'pauseVoice',
            'stopVoice',
            'uploadVoice',
            'downloadVoice',
            'chooseImage',
            'previewImage',
            'uploadImage',
            'downloadImage',
            'getNetworkType',
            'openLocation',
            'getLocation',
            'hideOptionMenu',
            'showOptionMenu',
            'closeWindow',
            'scanQRCode',
            'chooseWXPay',
            'openProductSpecificView',
            'addCard',
            'chooseCard',
            'openCard'
        ]
    });
    
    var appID='wx9e02167350e25524';
    var secret='6c7242296675c22e6cbe3fd084f51db1';
    
    var url=window.location.href;
    var code=url.substring( url.indexOf("code=")+5,url.indexOf("&state"));
    var AccessToken;
    //var openID;
    
    var ComCode=null;
    var ComName=null;
    var ComPrice=null;
    
    var nickname;
    var sex;
    var address;
    var headimgurl;
    
window.onload=function(){
    
    
}

    wx.ready(function () {
        
        $.ajax({
        url:"/test3/php.php",
        data:{
        	"type":"GetAccessToken",
        	"appID":appID,
        	"secret":secret,
        	"code":code
        },
        type:"get",
        success:function(data){
            
            var obj=$.parseJSON(data);    
            AccessToken=obj.AccessToken;
            openID=obj.openID;
            //alert(AccessToken);
            //alert(openID);
            
            //GOTO:成功获取到accessToken,可以进行接下去的操作
            
                 $.ajax({
                 url:"/test3/php.php",
                 data:{
                    "type":"GetUserInfo",
                    "openID": openID,
                    "AccessToken": AccessToken
                 },
                 type:"get",
                 success:function(result){
                     //成功获取到用户信息
                     
                     var object=$.parseJSON(result);
                     alert(object.msg);
                     //openID=object.openID;
                     
                    /* nickname=object.nickname;
                     sex=object.sex;
                     switch(sex)
                     {	
                         case 0: sex="不确定"; break;
                         case 1: sex="男"; break;
                         case 2: sex="女"; break;
                         default: break;
                     }
                     address = object.country +" "+ object.province +" "+ object.city;
                     headimgurl = object.headimgurl;
                     
                     //alert(headimgurl);*/
                     //数据测试均无误，可以将openid通过“点击个人中心”传给后台查询数据库，再到login.php进行显示

                     
                     
                     
                     
                     
                     
                 },
                 error:function(e,x,th){
                     console.log(333333);
                 }
              });        
            
        },
        error:function(e,x,th){
        	console.log(22222);
        }
    });
        
        document.querySelector('#query').onclick = function () {
            wx.scanQRCode({
                needResult: 1,
                desc: 'scanQRCode desc',
                success: function (res) {
                    var serialNumber = res.resultStr;

                    if(serialNumber.indexOf(',') > 0){
                        var dealserialNumber=serialNumber.split(',')[1];
                        dealserialNumber = dealserialNumber.replace(/[^a-z\d]/ig, "");
                        $.get("getA.php",{ expNo:dealserialNumber},function(data,status){
                            //alert(dealserialNumber);
                            ComCode=dealserialNumber;
                            ComName=data.Name;
                            ComPrice=data.Price;

                            $(".code").html("商品条码号:"+dealserialNumber);
                            $(".Name").html("商品名称:"+data.Name);
                            $(".Price").html("商品价格:"+data.Price+"元");
                        });
                    }else{


                        $.get("getA.php",{ expNo:serialNumber},function(data,status){
                        });
                    }
                }
            });
        };
       
    });

     $('[data-sidenav]').sidenav().style.cursor="pointer";
    
    
    wx.error(function (res) {
        alert(res.errMsg);
    });
    
    
    
</script>
</body>
</html>



