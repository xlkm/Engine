
var url1 = "http://ehire.51job.com/MainLogin.aspx";
var userNameID = "txtMemberNameCN";
var userNameID2 = "txtUserNameCN";
var passwordID = "txtPasswordCN";
var clickId = "Login_btnLoginCN";
var userName= "万礼聚诚";
var userName2 = "wljc457";
var password = "abc123";
var emailId = "MainMenuNew1_hlInBox";
var selectAllId = "radSelactALL";
var exprotId = "inputbtnExport";
var downloadUid = "exportDialog";
var downloadUpath = "u-2-0-0";

function start()
{	
	GoToByUrl(url1);
	SetValueById(userNameID,userName);
	SetValueById(userNameID2,userName2);
	SetValueById(passwordID,password);
	ClickById(clickId);
	ClickById(emailId);
	ClickById(selectAllId);
	ClickById(exprotId);
	ClickByIdAndUpath(downloadUid,downloadUpath);
	//ClickById();
}


/*
function GoToByUrl(urlString)
{
    window.external.SetCurrentMethod("GoToByUrl",JS2VBArray([urlString]));
}

function SetValueById(id,value)
{
    window.external.SetCurrentMethod("SetValueById",JS2VBArray([id,value]));
}

function SetValueByName(name,number,value)
{
    window.external.SetCurrentMethod("SetValueByName",JS2VBArray([name,number,value]));
}

function ClickByIdAndUpath(id,upath)
{
    window.external.SetCurrentMethod("ClickByIdAndUpath",JS2VBArray([id,upath]));
}

function ClickById(id)
{
    window.external.SetCurrentMethod("ClickById",JS2VBArray([id,upath]));
}

*/