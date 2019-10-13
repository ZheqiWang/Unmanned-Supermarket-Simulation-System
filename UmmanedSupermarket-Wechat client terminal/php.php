<?php
header("Content-type: text/html; charset:utf-8");
header("Access-Control-Allow-Origin:*");
header("Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept");
define("SAE_MYSQL_USER","kj002y220x");
define("SAE_MYSQL_PASS","wh1wk1z51llwy24h4ximl00hkwll1ix1ljwjyizm");
define("SAE_MYSQL_HOST_M","w.rdc.sae.sina.com.cn");
define("SAE_MYSQL_HOST_S","r.rdc.sae.sina.com.cn");
define("SAE_MYSQL_PORT","3306");
define("SAE_MYSQL_DB","app_578366017");

$Event;
switch($_REQUEST["type"]) {
    case 'GetAccessToken':
        $Event = new GetAccessToken();
        break;
    case 'GetUserInfo':
        $Event = new GetUserInfo();
        break;
    case 'GetComBuy':
        $Event = new GetComBuy();
        break;
    case 'GetLoginUserInfo':
        $Event = new GetLoginUserInfo();
        
       
    default:
        break;
    }

$Event->DoSth();

    Class GetAccessToken{
        function DoSth(){
            $appID=$_GET['appID'];
            $secret=$_GET['secret'];
            $code=$_GET["code"];
            $url="https://api.weixin.qq.com/sns/oauth2/access_token?appid=".$appID."&secret=".$secret."&code=".$code."&grant_type=authorization_code";
            $html = json_decode(file_get_contents($url));
            
            $openid=$html->openid;
            $accesstoken=$html->access_token;
            $data=array('AccessToken'=>$accesstoken,"openID"=>$openid);
            echo json_encode($data);
            //echo $html->access_token;
        }
    };

	Class GetUserInfo{
        function DoSth(){
            $openid=$_GET['openID'];
            $AccessToken=$_GET['AccessToken'];
            $url="https://api.weixin.qq.com/sns/userinfo?access_token=".$AccessToken."&openid=".$openid."&lang=zh_CN ";
            $html = json_decode(file_get_contents($url));
            
            $nickname = $html->nickname;
            $sex = $html->sex;
            $language = $html->language;
            $city = $html->city;
            $province = $html->province;
            $country = $html->country;
            $headimgurl = $html->headimgurl;
            
            $result=array('msg'=>"等你好久啦~$nickname",'openID'=>$openid,"nickname"=>$nickname,"sex"=>$sex,"language"=>$language,"city"=>$city,"province"=>$province,"country"=>$country,"headimgurl"=>$headimgurl);
            //echo json_encode($result); 
            /*
            {   回复的用户信息json格式
                "openid": "oLVPpjqs9BhvzwPj5A-vTYAX3GLc",
                "nickname": "刺猬宝宝",
                "sex": 1,   //1为男，2为女，0为未知
                "language": "简体中文",
                "city": "深圳",
                "province": "广东",
                "country": "中国",
                "headimgurl": "http://wx.qlogo.cn/mmopen/utpKYf69VAbCRDRlbUsPsdQN38DoibCkrU6SAMCSNx558eTaLVM8PyM6jlEGzOrH67hyZibIZPXu4BK1XNWzSXB3Cs4qpBBg18/0",
                "privilege": []
            }
            */
            
            //将信息存入数据库用户表
            
            //$db = mysql_connect(SAE_MYSQL_HOST_M.':'.SAE_MYSQL_PORT,SAE_MYSQL_USER,SAE_MYSQL_PASS);     输出Deprecated错误
            $db = mysqli_connect(SAE_MYSQL_HOST_M.':'.SAE_MYSQL_PORT,SAE_MYSQL_USER,SAE_MYSQL_PASS);

            if ($db)
            {
                $mysql= new SaeMysql();
                
                $sql = "select openID from UserInfo where openID='$openid '";
                $sqlresult=$mysql->getVar($sql);
                
               if($sqlresult==$openid)
                {
                   //检测用户是否已经登录过
                   $result=array('msg'=>"好久不见，甚是想念❤                 欢迎你！$nickname",'openID'=>$openid,"nickname"=>$nickname,"sex"=>$sex,"language"=>$language,"city"=>$city,"province"=>$province,"country"=>$country,"headimgurl"=>$headimgurl);
                }
                else 
                {
                    $result=array('nickname'=>$sqlresult);
                    $mysql1= new SaeMysql();
                    $sql1 = "insert into UserInfo(openID,nickname,sex,language,city,province,country,headimgurl,account)
                    		values('$openid','$nickname','$sex','$language','$city','$province','$country','$headimgurl','100') ";
                	$mysql1->runSql( $sql1 ); 
                    if( $mysql->errno() != 0 )
                    {
                        die( "Error:" . $mysql->errmsg() );
                    }
            	}
            }
            else
            {
               $result=array('msg'=>"database read error");
            }
                
            echo json_encode($result); 
            
            
            
        }
    };


	 Class GetComBuy{
        function DoSth(){
            $Code=$_GET['Code'];//商品条码号
            $Name=$_GET['Name'];
            $Price=$_GET['Price'];
            $openID=$_GET['openID'];
            
            if($openID==null)
            {
                $buyresult=array("extra"=>$openID,"msg"=>"请先登录！登录后才可购买哟~");
            }
            else
            {
                $mysql= new SaeMysql();    
                $sql = "select account from UserInfo where openID='$openID '";
                $account=$mysql->getVar($sql);
                
                $sql = "select Valid from Onshelf where ComBar='$Code '";
                $Valid=$mysql->getVar($sql);

                $account=(float)$account;
                $Price=(float)$Price;
                $extra=$account-$Price;//账户余额
                
                if($extra>0 && $Valid==1)//判断账户内的钱是否够付款
                {
                    
                
                    //进行购买操作的数据库订单插入，account更改和上架单有效位更改
                    $db = mysqli_connect(SAE_MYSQL_HOST_M.':'.SAE_MYSQL_PORT,SAE_MYSQL_USER,SAE_MYSQL_PASS);

                    if ($db)
                    {
                        //重新设置UserInfo表中的account账户余额
                        $mysql= new SaeMysql();
                        $sql = "update UserInfo set account='$extra' where openID='$Code '";
                        $mysql->runSql( $sql );
                        //取出商品对应的RFID号
                        $sql3 = "select RFID from Onshelf where ComBar='$openID '";
                        $sqlresult=$mysql->getVar($sql3);
                        //将购买商品的信息插入OrderInfo表
                        $BuyDate=date("Y/m/d");//购买日期
                        $sql1 = "insert into OrderInfo(openID,ComBar,ComName,Price,BuyDate,RFID)
                                values('$openID','$Code','$Name','$Price','$BuyDate','$sqlresult') ";
                        $mysql->runSql( $sql1 );
                        //将Onshelf上架商品表中的Valid改为0，表示商品已售出
                        $sql2 = "update Onshelf set Valid=0 where ComBar='$Code ' ";
                        $mysql->runSql( $sql2 );
                        
                        $buyresult=array('Name'=>$Name,"extra"=>$extra,"msg"=>"商品购买成功！","openID"=>$openID);
                    }
                    else
                    {
                        $buyresult=array("msg"=>"database connect error");
                    }
                }
                else
                {
                    if($extra<=0){ $buyresult=array("msg"=>"账户内的钱不够了T_T");}
                    if($Valid==0){ $buyresult=array("msg"=>"咦？商品已经被卖掉了哦~");}
                }
                
            }
            
           
            echo json_encode($buyresult); 
        }
    };

	Class GetLoginUserInfo{
        function DoSth(){
            $openID=$_GET['openID'];
            
            
            
             
            if($openID=="http")
            {
                $showdata=array("nickname"=>$openID,"msg"=>"诶？你没有登录呀");
            }
            else
            {
                $mysql= new SaeMysql();    
                //微信名
                $sql = "select nickname from UserInfo where openID='$openID '";
                $nickname=$mysql->getVar($sql);
               
                //性别
                $sql = "select sex from UserInfo where openID='$openID '";
                $sex=$mysql->getVar($sql);
                switch($sex)
                     {	
                         case 0: $sex="不确定"; break;
                         case 1: $sex="男"; break;
                         case 2: $sex="女"; break;
                         default: break;
                     }
                //地址
                $sql = "select city from UserInfo where openID='$openID '";
                $city = $mysql->getVar($sql);
                $sql = "select province from UserInfo where openID='$openID '";
                $province=$mysql->getVar($sql);
                $sql = "select country from UserInfo where openID='$openID '";
                $country = $mysql->getVar($sql);
                $address = $country ." ". $province ." ". $city;
                //头像 + 账户余额
                $sql = "select headimgurl from UserInfo where openID='$openID '";
                $headimgurl=$mysql->getVar($sql);	
                $sql = "select account from UserInfo where openID='$openID '";
                $account=$mysql->getVar($sql);
                $showdata=array('msg'=>"你已经登录啦~","nickname"=>$nickname,"sex"=>$sex,"address"=>$address,"headimgurl"=>$headimgurl,"account"=>$account);
                
        }
            
            
            echo json_encode($showdata);
            //echo $html->access_token;
        }
    };
            
?>