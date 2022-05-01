let acct = document.querySelector(".on-account"); // acct -- account
let acctW = document.querySelector(".account-wrapper");

let stgs = document.querySelector(".settings-wrapper"); // setgs -- settings
let navStg = document.querySelector(".on-settings"); // navStg -- nav setting (setting in nav list)

let vAsset = document.querySelector(".on-view-asset"); // vAsset = view asset
let vAssetItm = document.querySelector(".view-asset-item-wrapper"); // vAssetItm  -- view asset item 

let maint = document.querySelector(".on-maintenance"); // maint -- maintenance
let maintItm = document.querySelector(".maintenance-item-wrapper"); // maintItm -- maintenance item

let submReq = document.querySelector(".on-submit-request"); // submReq -- submit request
let submReqItm = document.querySelector(".submit-request-item-wrapper"); // submReq -- submit request item 

let auth = document.querySelector(".on-authorize"); // auth -- authorize
let authItm = document.querySelector(".authorize-item-wrapper"); // authItm -- authorize item


let ext = document.querySelector(".on-exit"); // ext -- exit
let extItm = document.querySelector(".exit-item-wrapper"); // extItm -- exit Item 


let dropbtn = document.querySelector(".drop-button"); // dropbtn -- drop button


let pullAccount = function () {
    acctW.classList.add("display-account");
    stgs.classList.remove("display-settings");
    vAssetItm.classList.remove("display-view-aasset");
    maintItm.classList.remove("display-maintenance");
    submReqItm.classList.remove("display-submit-request");
    authItm.classList.remove("display-authorize");
    extItm.classList.remove("display-exit");
    dropbtn.classList.add("dropbtn");
}

let pullSettings = function () {
    acctW.classList.remove("display-account");
    stgs.classList.add("display-settings");
    vAssetItm.classList.remove("display-view-aasset");
    maintItm.classList.remove("display-maintenance");
    submReqItm.classList.remove("display-submit-request");
    authItm.classList.remove("display-authorize");
    extItm.classList.remove("display-exit");
    dropbtn.classList.add("dropbtn");
}

let pullViewAsset = function () {

    vAssetItm.classList.add("display-view-aasset");
    acctW.classList.remove("display-account");
    stgs.classList.remove("display-settings");
    maintItm.classList.remove("display-maintenance");
    submReqItm.classList.remove("display-submit-request");
    authItm.classList.remove("display-authorize");
    extItm.classList.remove("display-exit");
    dropbtn.classList.add("dropbtn");

}

let pullMaintenance = function () {
    maintItm.classList.add("display-maintenance");
    vAssetItm.classList.remove("display-view-aasset");
    acctW.classList.remove("display-account");
    stgs.classList.remove("display-settings");
    submReqItm.classList.remove("display-submit-request");
    authItm.classList.remove("display-authorize");
    extItm.classList.remove("display-exit");
    dropbtn.classList.add("dropbtn");

}

let pullSubmitRequest = function () {
    maintItm.classList.remove("display-maintenance");
    acctW.classList.remove("display-account");
    vAssetItm.classList.remove("display-view-aasset");
    stgs.classList.remove("display-settings");
    submReqItm.classList.add("display-submit-request");
    authItm.classList.remove("display-authorize");
    extItm.classList.remove("display-exit");
    dropbtn.classList.add("dropbtn");

}

let pullAuthorize = function () {
    maintItm.classList.remove("display-maintenance");
    acctW.classList.remove("display-account");
    vAssetItm.classList.remove("display-view-aasset");
    stgs.classList.remove("display-settings");
    submReqItm.classList.remove("display-submit-request");
    authItm.classList.add("display-authorize");
    extItm.classList.remove("display-exit");
    dropbtn.classList.add("dropbtn");

}

let pullExit = function () {
    maintItm.classList.remove("display-maintenance");
    acctW.classList.remove("display-account");
    vAssetItm.classList.remove("display-view-aasset");
    stgs.classList.remove("display-settings");
    submReqItm.classList.remove("display-submit-request");
    authItm.classList.remove("display-authorize");
    extItm.classList.add("display-exit");
    dropbtn.classList.add("dropbtn");

}

let pushDown = function ()
{
    maintItm.classList.remove("display-maintenance");
    acctW.classList.remove("display-account");
    vAssetItm.classList.remove("display-view-aasset");
    stgs.classList.remove("display-settings");
    submReqItm.classList.remove("display-submit-request");
    authItm.classList.remove("display-authorize");
    extItm.classList.remove("display-exit");
    dropbtn.classList.remove("dropbtn");
}


acct.addEventListener("click", pullAccount);
navStg.addEventListener("click", pullSettings);
vAsset.addEventListener("click",pullViewAsset);
maint.addEventListener("click",pullMaintenance);
submReq.addEventListener("click",pullSubmitRequest);
auth.addEventListener("click",pullAuthorize);
ext.addEventListener("click",pullExit);
dropbtn.addEventListener("click",pushDown);
