﻿<?php
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
<body class="page-query member-login-page" style={{cursor:'pointer'}} onload="showInfo()">

<header class="page-title" style={{cursor:'pointer'}}>
    <!--<script data-main="http://ucmp-static.sf-express.com/cx/scripts/query/query.main" src="require.js" charset="utf-8"></script>-->
    <a class="sidenav" data-sidenav data-sidenav-toggle="#sidenav-toggle" >
        <div class="sidenav-header" id="mainpage" onclick="window.location.href='sample.php'">
            无人超市
        </div>

        <div class="sidenav-brand" onclick="window.location.href='login.php'">
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
   <div class="track-rcol" style="position:relative;">
    <div>
        <img id="img1" style="width:128; height:128;left:50%;transform:translate(-50%,0);" ><br/>
    </div>
    <div>
        <span></span><br/>
        <span id="nickname" style="font-size:20px"></span><br/>
        <span id="sex" style="font-size:20px"></span><br/>
        <span id="location" style="font-size:20px"></span><br/>
        <span id="account" style="font-size:20px"></span><br/>
        
    </div> 
       <!-- <ul id="FileCollection">

        </ul>-->
    
</div>

    

    <div >
        <br/>
    <input type="submit" name="submit" value="登录" style="font-size:20px;font-family:'黑体';color:#545454;padding:5;width:120;margin:0 auto;border-radius:4px;border:1px solid  #DBDBDB;"
           id="login">
        <br/>
    </div>
    
    <!--<input type="text"  id ="ee" onclick="showcode()"/>  -->
    

<script type="text/javascript" src="jquery.js"></script>
<script src="dist/sidenav.min.js"></script>
<script type="text/javascript">
    
    var nickname = null;
    var sex = null;
    var address = null;
    var headimgurl = null;
    var account = null;
    
     var url=window.location.href;
     var code=url.substring( url.indexOf("code=")+5,url.indexOf("&AccessToken="));//openID=code
     //var accesstoken=url.substring( url.indexOf("AccessToken=")+12,url.indexOf("&forR"));
    //alert(accesstoken);

     $.ajax({
                    url:"/test3/php.php",
                    data:{
                        "type":"GetLoginUserInfo",
                        "openID":code,
                    },
                    type:"get",
                    success:function(showdata){
                        var showInfo=$.parseJSON(showdata);
                        //alert(showInfo.msg);
                        //openid必须先点击login.php中的登录按键跳转到主页面，从主页面进入个人中心才能获取
                        
                        nickname = showInfo.nickname;
                        sex = showInfo.sex;
                        address = showInfo.address;
                        headimgurl = showInfo.headimgurl;
                        account = showInfo.account;
                        
                        if(nickname=="http")
                        {
                            alert("请先登录！");
                        }
                        else
                        {
                            $("#img1").attr("src",headimgurl); 
                            //alert(address);
                            $("#nickname").html("微信号"+nickname);
                           // $(".nickname").value = nickname;
                            $("#sex").html("性别:"+sex);
                            $("#location").html("地址:"+address);
                            $("#account").html("账户余额:"+account);
                        }
                        
                        
                        
                        
                        },
                    error:function(e,x,th){
                        alert(7777777);
                   	 }
              });
   
    
    
    
     
    //显示头像
  // var headimgurl="http://thirdwx.qlogo.cn/mmopen/vi_32/DYAIOgq83epVViaIs4SoYGxuQNOOKpzicR1wJFwyK4NDxuQLaAfbqGPrDJoPeWAAIiaY0yOSicBt9C0tWfK6J4k2uQ/132" ;
   
   
   //点击登录跳转到主页面 
   $("#login").click(function(){
       //alert(1);
       
       //非测试号
       //var appid = 'wx8c7aff23f6fd28dc';
       var appid = 'wx9e02167350e25524';
       console.log(appid);
       //alert(appid);
       
       //非测试号
       //var secret = '5a1c097578dbc30b8f7661e6365023d7';
       
       var secret='6c7242296675c22e6cbe3fd084f51db1';
       
       console.log(secret);

       //alert(secret);
       //var redirect_uri = UrlEncode ( 'http://1.578366017.applinzi.com');
       //var redirect_uri = "http%3a%2f%2f1.578366017.applinzi.com";
       var redirect_uri=encodeURIComponent('http://1.578366017.applinzi.com/test3/sample.php');
                     console.log(redirect_uri);

       
      //console.log("https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + appid + "&redirect_uri=" + redirect_uri + "&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect");
      window.location.href = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + appid + "&redirect_uri=" + redirect_uri + "&response_type=code&scope=snsapi_userinfo#wechat_redirect";
       
       //alert(1);
       //location.href = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx9e02167350e25524&redirect_uri=http%3a%2f%2f1.578366017.applinzi.com&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect";
       
       /**/
       
      
   
   });
    
    $('[data-sidenav]').sidenav().style.cursor="pointer";

    
   
    
    
</script>
</body>
</html>





<?php

//scope=snsapi_userinfo实例
//第一步，获取code
/*$appid='wx9e02167350e25524 ';
$secret = "6c7242296675c22e6cbe3fd084f51db1 ";
$redirect_uri = urlencode ( 'http://1.578366017.applinzi.com' );
$url ="https://open.weixin.qq.com/connect/oauth2/authorize?appid=$appid&redirect_uri=$redirect_uri&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect";
header("Location:".$url);


$appid = "wx9e02167350e25524";  
  
$code = $_GET["code"];
echo $code;
*/
/*第二步:取得access_token
$oauth2Url = "https://api.weixin.qq.com/sns/oauth2/access_token?appid=$appid&secret=$secret&code=$code&grant_type=authorization_code";
$oauth2 = getJson($oauth2Url);
  
//第二步:根据全局access_token和openid查询用户信息
$openid = $oauth2['openid']; 
$access_token = $oauth2["access_token"];  
$get_user_info_url = "https://api.weixin.qq.com/cgi-bin/user/info?access_token=$access_token&openid=$openid&lang=zh_CN";
$userinfo = getJson($get_user_info_url);
 
//打印用户信息
print_r($userinfo);

function getJson($url){
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, FALSE); 
    curl_setopt($ch, CURLOPT_SSL_VERIFYHOST, FALSE); 
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
    $output = curl_exec($ch);
    curl_close($ch);
    return json_decode($output, true);
}*/
?>

