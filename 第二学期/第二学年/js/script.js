const xhr = new XMLHttpRequest();
const endPoint= `https://api.themoviedb.org/3/movie/now_playing?api_key=db24d0635504752f9cec19e18a6841eb&language=en-US&page=1`;
xhr.open("GET",endPoint);
xhr.send();
xhr.onload = function (){
if(xhr.readyState==4)
{
 let temp = JSON.parse(xhr.responseText);
 /* first moive*/
 let sec11 = document.querySelector("#sec11");
 let poster1 = document.querySelector("#poster");
 poster1.href="../html/detail.html";
 let image= document.createElement("img");
 image.setAttribute("src","https://image.tmdb.org/t/p/w185_and_h278_bestv2"+temp.results[0].poster_path);
 poster1.appendChild(image);
 /*first element*/
 let info1 = document.querySelector("#info");
 let label1= document.createElement("lable");
 label1.innerHTML=temp.results[0].title;
 label1.style.fontWeight="bold";
 label1.style.fontSize="22px";
 info1.appendChild(label1);
  /*second element*/
 let label14= document.createElement("lable");
 label14.innerHTML="&nbsp&nbsp"+temp.results[0].vote_average;
 label14.style.fontSize="32px";
 info1.appendChild(label14);
  /*3 element*/
 let label12= document.createElement("lable");
 label12.innerHTML="<br><br>"+temp.results[0].release_date;
 info1.appendChild(label12);
  /*4 element*/
 let label13= document.createElement("lable");
 label13.innerHTML="<br><br>"+temp.results[0].overview;
 info1.appendChild(label13);
  /*5 element*/
 let a1= document.createElement("a");
 a1.setAttribute("href","../html/detail.html");
 a1.innerHTML="<br><br><br><br><br><br><br>More Info";
 a1.style.textDecoration="none";
 a1.style.color="black";
 info1.appendChild(a1);
  /* second moive*/
 let sec22 = document.querySelector("#sec22");
 let poster2 = document.querySelector("#poster2");
 /*poster2.href="../html/detail.html";*/
 let image2= document.createElement("img");
 image2.setAttribute("src","https://image.tmdb.org/t/p/w185_and_h278_bestv2"+temp.results[1].poster_path);
 poster2.appendChild(image2);
 let info2 = document.querySelector("#info2");
 let label2= document.createElement("label");
 label2.innerHTML=temp.results[1].title;
 label2.style.fontWeight="bold";
 label2.style.fontSize="22px";
 info2.appendChild(label2);
 let label24= document.createElement("lable");
 label24.innerHTML="&nbsp&nbsp"+temp.results[1].vote_average;
 label24.style.fontSize="32px";
 info2.appendChild(label24);
 let label22= document.createElement("lable");
 label22.innerHTML="<br><br>"+temp.results[1].release_date;
 info2.appendChild(label22);
 let label23= document.createElement("lable");
 label23.innerHTML="<br><br>"+temp.results[1].overview;
 info2.appendChild(label23);
  let a2= document.createElement("a");
 a2.setAttribute("href","../html/detail.html");
 a2.innerHTML="<br><br><br>More Info";
 a2.style.textDecoration="none";
 a2.style.color="black";
 info2.appendChild(a2);
/* third moive*/
let sec33 = document.querySelector("#sec33");
 let poster3 = document.querySelector("#poster3");
 /*poster3.href="../html/detail.html";*/
 let image3= document.createElement("img");
 image3.setAttribute("src","https://image.tmdb.org/t/p/w185_and_h278_bestv2"+temp.results[2].poster_path);
 poster3.appendChild(image3);
 /*first element*/
 let info3 = document.querySelector("#info3");
 let label3= document.createElement("lable");
 label3.innerHTML=temp.results[2].title;
 label3.style.fontWeight="bold";
 label3.style.lineHeight="1.55em";
 label3.style.fontSize="22px";
 info3.appendChild(label3);
  /*second element*/
 let label34= document.createElement("lable");
 /*label34innerHTML="&nbsp&nbsp"+temp.results[2].vote_average;*/
 label34.innerHTML="&nbsp&nbsp"+temp.results[2].vote_average;
 label34.style.fontSize="32px";
 info3.appendChild(label34);
  /*3 element*/
 let label32= document.createElement("lable");
 label32.innerHTML="<br><br>"+temp.results[2].release_date;
 info3.appendChild(label32);
  /*4 element*/
 let label33= document.createElement("lable");
 label33.innerHTML="<br><br>"+temp.results[2].overview;
 info3.appendChild(label33);
  /*5 element*/
 let a3= document.createElement("a");
 a3.setAttribute("href","../html/detail.html");
 a3.innerHTML="<br><br>More Info";
 a3.style.textDecoration="none";
 a3.style.color="black";
 info3.appendChild(a3);
  /* 4 moive*/
 let sec44= document.querySelector("#sec44");
 let poster4 = document.querySelector("#poster4");
 /*poster2.href="../html/detail.html";*/
 let image4= document.createElement("img");
 image4.setAttribute("src","https://image.tmdb.org/t/p/w185_and_h278_bestv2"+temp.results[3].poster_path);
 poster4.appendChild(image4);
 let info4= document.querySelector("#info4");
 let label4= document.createElement("label");
 label4.innerHTML=temp.results[3].title;
 label4.style.fontWeight="bold";
 label4.style.fontSize="22px";
 info4.appendChild(label4);
 let label44= document.createElement("lable");
 label44.innerHTML="&nbsp&nbsp"+temp.results[3].vote_average;
 label44.style.fontSize="32px";
 info4.appendChild(label44);
 let label42= document.createElement("lable");
 label42.innerHTML="<br><br><br><br>"+temp.results[3].release_date;
 info4.appendChild(label42);
 let label43= document.createElement("lable");
 label43.innerHTML="<br><br>"+temp.results[3].overview;
 info4.appendChild(label43);
 let a4= document.createElement("a");
 a4.setAttribute("href","../html/detail.html");
 a4.innerHTML="<br><br><br><br><br><br>More Info";
 a4.style.textDecoration="none";
 a4.style.color="black";
 info4.appendChild(a4);
 /* 5 moive*/
let sec55 = document.querySelector("#sec55");
 let poster5 = document.querySelector("#poster5");
 /*poster3.href="../html/detail.html";*/
 let image5= document.createElement("img");
 image5.setAttribute("src","https://image.tmdb.org/t/p/w185_and_h278_bestv2"+temp.results[4].poster_path);
 poster5.appendChild(image5);
 /*first element*/
 let info5 = document.querySelector("#info5");
 let label5= document.createElement("lable");
 label5.innerHTML=temp.results[4].title;
 label5.style.fontWeight="bold";
 label5.style.lineHeight="1.55em";
 label5.style.fontSize="22px";
 info5.appendChild(label5);
  /*second element*/
 let label54= document.createElement("lable");
 /*label34innerHTML="&nbsp&nbsp"+temp.results[2].vote_average;*/
 label54.innerHTML="&nbsp&nbsp"+temp.results[4].vote_average;
 label54.style.fontSize="32px";
 info5.appendChild(label54);
  /*3 element*/
 let label52= document.createElement("lable");
 label52.innerHTML="<br><br>"+temp.results[4].release_date;
 info5.appendChild(label52);
  /*4 element*/
 let label53= document.createElement("lable");
 label53.innerHTML="<br><br>"+temp.results[4].overview;
 info5.appendChild(label53);
  /*5 element*/
 let a5= document.createElement("a");
 a5.setAttribute("href","../html/detail.html");
 a5.innerHTML="<br><br><br><br><br>More Info";
 a5.style.textDecoration="none";
 a5.style.color="black";
 info5.appendChild(a5);
 /* 6 moive*/
 let sec66= document.querySelector("#sec66");
 let poster6 = document.querySelector("#poster6");
 /*poster2.href="../html/detail.html";*/
 let image6= document.createElement("img");
 image6.setAttribute("src","https://image.tmdb.org/t/p/w185_and_h278_bestv2"+temp.results[5].poster_path);
 poster6.appendChild(image6);
 let info6= document.querySelector("#info6");
 let label6= document.createElement("label");
 label6.innerHTML=temp.results[5].title;
 label6.style.fontWeight="bold";
 label6.style.fontSize="22px";
 info6.appendChild(label6);
 let label64= document.createElement("lable");
 label64.innerHTML="&nbsp&nbsp"+temp.results[5].vote_average;
 label64.style.fontSize="32px";
 info6.appendChild(label64);
 let label62= document.createElement("lable");
 label62.innerHTML="<br><br><br><br>"+temp.results[5].release_date;
 info6.appendChild(label62);
 let label63= document.createElement("lable");
 label63.innerHTML="<br><br>"+temp.results[5].overview;
 info6.appendChild(label63);
 let a6= document.createElement("a");
 a6.setAttribute("href","../html/detail.html");
 a6.innerHTML="<br><br><br><br><br>More Info";
 a6.style.textDecoration="none";
 a6.style.color="black";
 info6.appendChild(a6);
}
}
