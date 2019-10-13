
<!DOCTYPE html>
<html>
<head>

    <meta charset="utf-8">
    <meta name="viewport"
          content="width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no">
    <meta name="format-detection" content="telephone=no, email=no">
    <title>W无人超市</title>
    <style>
        body{font-size: 12px; background-color:#d0e4fe}
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
        span
        {
            font-size:20px;
            text-align: center;
            display:block;
            font-family:"思源黑体";
        }
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
        <div class="sidenav-header" onclick="window.location.href='sample.php'">
            无人超市
        </div>

        <div class="sidenav-header" onclick="window.location.href='login.php'">
            个人中心
        </div>
        <div class="sidenav-header" onclick="window.location.href='introduce.html'">
            超市简介
        </div>
        <div class="sidenav-brand" onclick="window.location.href='contactus.php'">
            联系我们
        </div>




    </a>
    <a class="my-nav" href="javascript:;" id="sidenav-toggle" id ="show" ></a>



    <h1 class="title">欢迎来到无人超市</h1>
</header>


    <div >
        <img id="img1" src="img/7878.png">
    </div>
    <span></span><br/>
        <span  style="font-size:20px;text-align: center;display:block;font-family:"思源黑体"">联系电话：15800611389</span><br/>
        <span  style="font-size:20px;text-align: center;display:block;font-family:"思源黑体"">邮箱：578366017@qq.com</span><br/>


<script type="text/javascript" src="jquery.js"></script>
<script src="dist/sidenav.min.js"></script>
<script type="text/javascript">
   $('[data-sidenav]').sidenav().style.cursor="pointer";
</script>
</body>
</html>



