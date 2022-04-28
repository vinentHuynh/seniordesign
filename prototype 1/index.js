let navSetgs = document.querySelector(".nav-settings");

let stgCont = document.querySelector(".settings");

let count =1;
isClicked = false;
navSetgs.addEventListener("click", (e)=>
{

   if(count == 1)
   {
        navSetgs.classList.add("show");
        stgCont.classList.add("show");

   } 

})