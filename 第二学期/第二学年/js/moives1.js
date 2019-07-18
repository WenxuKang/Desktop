const xhr = new XMLHttpRequest();
const endPoint= `https://api.themoviedb.org/3/movie/now_playing?api_key=db24d0635504752f9cec19e18a6841eb&language=en-US&page=1`;
xhr.open("GET",endPoint);
xhr.send();
xhr.onload = function (){
if(xhr.readyState==4)
{
let temp = JSON.parse(xhr.responseText);
let sec11 = document.querySelector("#sec11");
let image= document.createElement("img");
 image.setAttribute("src","https://image.tmdb.org/t/p/w300_and_h450_bestv2/xnopI5Xtky18MPhK40cZAGAOVeV.jpg");
 image.style.height="100%";
 sec11.appendChild(image);

 let moive1 = document.querySelector("#moive1");
 let label1= document.createElement("lable");
 label1.innerHTML=temp.results[0].title;
 label1.style.fontWeight="bold";
 label1.style.fontSize="34px";
 label1.style.color="#ffffff";
 moive1.appendChild(label1);
 let label12= document.createElement("lable");
 label12.innerHTML="(2019)";
 label12.style.fontSize="22px";
 label12.style.color="#ffffff";
 moive1.appendChild(label12);


let label15= document.createElement("lable");
 label15.innerHTML="<br><br>Popularity&nbsp"+temp.results[0].popularity;
  label15.style.fontSize="20px";
label15.style.color="#ffffff";
 moive1.appendChild(label15);
 let label16= document.createElement("lable");
 label16.innerHTML="&nbsp&nbsp&nbsp&nbspLanguage&nbsp"+temp.results[0].original_language;
  label16.style.fontSize="20px";
label16.style.color="#ffffff";
 moive1.appendChild(label16);
let label14= document.createElement("lable");
 label14.innerHTML="<br><br>OverView";
  label14.style.fontSize="22px";
label14.style.color="#ffffff";
 moive1.appendChild(label14);
let label13= document.createElement("lable");
 label13.innerHTML="<br>"+temp.results[0].overview;
label13.style.color="#ffffff";
 moive1.appendChild(label13);
/*
let sec2 = document.querySelector("#sec2");
let label21= document.createElement("lable");
label21.innerHTML="Play Trailer";
label21.style.fontSize="26px";
label21.style.fontWeight="bold";
sec2.appendChild(label21);*/


const xhr2 = new XMLHttpRequest();
const endPoint2= `https://api.themoviedb.org/3/movie/${temp.results[0].id}/videos?api_key=db24d0635504752f9cec19e18a6841eb&language=en-US`;
xhr2.open("GET",endPoint2);
xhr2.send();
xhr2.onload = function (){
if(xhr2.readyState==4){
let temp2 = JSON.parse(xhr2.responseText);
let play2 = document.querySelector("#play");
/*play2.href=`https://www.themoviedb.org/video/play?key=${temp2.results[0].key}`;*/
play2.href=`https://www.themoviedb.org/movie/${temp.results[0].id}-${temp.results[0].title}?language=en-US#play=${temp2.results[0].key}`;
play2.style.textDecoration="none";
}
}
}
}


