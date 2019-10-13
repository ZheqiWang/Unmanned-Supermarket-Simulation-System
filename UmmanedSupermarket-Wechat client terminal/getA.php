<?php

//$url='http://1.578366017.applinzi.com/test3/testpage.html'.$_GET['expNo'];  //$url='你的接收网址，解决跨域问题'
//$html = file_get_contents($url);
//echo $html;

//$code=$_POST['expNo'];

define("SAE_MYSQL_USER","kj002y220x");
define("SAE_MYSQL_PASS","wh1wk1z51llwy24h4ximl00hkwll1ix1ljwjyizm");
define("SAE_MYSQL_HOST_M","w.rdc.sae.sina.com.cn");
define("SAE_MYSQL_HOST_S","r.rdc.sae.sina.com.cn");
define("SAE_MYSQL_PORT","3306");
define("SAE_MYSQL_DB","app_578366017");
//$db = mysql_connect(SAE_MYSQL_HOST_M.':'.SAE_MYSQL_PORT,SAE_MYSQL_USER,SAE_MYSQL_PASS);     输出Deprecated错误
$db = mysqli_connect(SAE_MYSQL_HOST_M.':'.SAE_MYSQL_PORT,SAE_MYSQL_USER,SAE_MYSQL_PASS);

$codeValue=$_GET['expNo'];


if ($db)
{
    $mysql= new SaeMysql();
    $sql = "select ComName from Onshelf where ComBar='$codeValue' ";
    $Name=$mysql->getVar($sql);
    $sql = "select Price from Onshelf where ComBar= '$codeValue' ";
    $Price=$mysql->getVar($sql);
    
    if($Name==false&&$Price=false)
    {
        $data=array('Name'=>$Name,"Price"=>$Price,"msg"=>"商品不存在 ?_? 请咨询工作人员");
    }
    else
    {
        $data=array('Name'=>$Name,"Price"=>$Price);
    }   
}
else
{
    $data=array('Name'=>$Name,"Price"=>$Price,"msg"=>"database read error");
}
header('Content-type:text/json');
echo json_encode($data);


//php返回json数据给script
//$data=array('id'=>001,'name'=>'商品名称','price'=>'商品价格');*/

//header('Content-type:text/json');
//echo json_encode($codeValue);

exit;

?>