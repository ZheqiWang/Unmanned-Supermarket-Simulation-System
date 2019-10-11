# Unmanned Supermarket Simulation System
## Summary   
A simulated system of unmanned supermarket. Include PC management model and Wechat platform client model (Web page based).  
## Environment  
PC management model - Windows Microsoft Visual Studio Win-Form Desktop Application.  
Wechat Client - Wechat broswer Web pag client.  
## File Description  
**UmmanedSupermarket-PCmanagement**    
无人超市PC管理端(Ummaned Supermarket PC management terminal):  
Contain all source code and .sln executable file of C# WinForm desktop application. PC model contains 9 parts.  
* Login: only for employee of supermarket.  
* Register: only for employee of supermarket.  
* MainForm: System entry interface, could choose any functions.  
* InWarehouse: Enter product information and corresponding barcode into the database.  
* OutWarehouse: Record expired or returned items.  
* OnSelf: Record the product information put on the shelf and pass the product information to the cloud database.  
* OffSelf: Record product information withdrawn from the shelf and delete the information from the cloud database.  
* Reader: connect RFID reader, get barcode of commodity.  
* Recommand: using Apriori algorithm, analyzing customer purchase information to make some recommandation. 

门禁演示(Access control demonstration): 
Access control module: When the unpaid goods pass through the door, the access control reads the RFID information and issues an alarm.

**UmmanedSupermarket-Wechat client terminal

