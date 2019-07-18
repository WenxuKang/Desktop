function calculatemetric(){
    var gender = document.getElementById('gendermetric').value;
    var weight = document.getElementById('weightmetric').value;
    var height = document.getElementById('heightmetric').value;
    var age = document.getElementById('agemetric').value;
    var level = document.getElementById('levelmetric').value;

    if (gender == 'male') {
        var firstop = 13.75 * weight;
        var secondop = 5.003 * height;
        var thirdop = 6.755 * age;
        var total = 66 + firstop + secondop - thirdop;
        var calories = total * level;
    }
    else if (gender == 'female') {
        var firstop = 9.563 * weight;
        var secondop = 1.850 * height;
        var thirdop = 4.676 * age;
        var total = 655.1 + firstop + secondop - thirdop;
        var calories = total * level;
    }
    document.getElementById('bmr').innerHTML = "BMR Calculation Result: " + total.toFixed(2);
    document.getElementById('calories').innerHTML = "Calories Calculation Result: " + calories.toFixed(2);
}

function CalculateImperial(){
    var gender = document.getElementById('genderimperial').value;
    var weight = document.getElementById('weightimperial').value;
    var height = document.getElementById('heightimperial').value;
    var age = document.getElementById('ageimperial').value;
    var level = document.getElementById('levelimperial').value;

    if (gender == 'male') {
        var firstop = 6.2 * weight;
        var secondop = 12.7 * height;
        var thirdop = 6.76 * age;
        var total = 66 + firstop + secondop - thirdop;
        var calories = total * level;
    }
    else if (gender == 'female') {
        var firstop = 4.35 * weight;
        var secondop = 4.7 * height;
        var thirdop = 4.7 * age;
        var total = 655.1 + firstop + secondop - thirdop;
        var calories = total * level;
    }
    document.getElementById('bmr').innerHTML = "BMR Calculation Result: " + total.toFixed(2);
    document.getElementById('calories').innerHTML = "Calories Calculation Result: " + calories.toFixed(2);
}

function FP_swapImg() {//v1.0
 var doc=document,args=arguments,elm,n; doc.$imgSwaps=new Array(); for(n=2; n<args.length;
 n+=2) { elm=FP_getObjectByID(args[n]); if(elm) { doc.$imgSwaps[doc.$imgSwaps.length]=elm;
 elm.$src=elm.src; elm.src=args[n+1]; } }
}

function FP_preloadImgs() {//v1.0
 var d=document,a=arguments; if(!d.FP_imgs) d.FP_imgs=new Array();
 for(var i=0; i<a.length; i++) { d.FP_imgs[i]=new Image; d.FP_imgs[i].src=a[i]; }
}

function FP_getObjectByID(id,o) {//v1.0
 var c,el,els,f,m,n; if(!o)o=document; if(o.getElementById) el=o.getElementById(id);
 else if(o.layers) c=o.layers; else if(o.all) el=o.all[id]; if(el) return el;
 if(o.id==id || o.name==id) return o; if(o.childNodes) c=o.childNodes; if(c)
 for(n=0; n<c.length; n++) { el=FP_getObjectByID(id,c[n]); if(el) return el; }
 f=o.forms; if(f) for(n=0; n<f.length; n++) { els=f[n].elements;
 for(m=0; m<els.length; m++){ el=FP_getObjectByID(id,els[n]); if(el) return el; } }
 return null;
}
function FP_swapImg() {//v1.0
 var doc=document,args=arguments,elm,n; doc.$imgSwaps=new Array(); for(n=2; n<args.length;
 n+=2) { elm=FP_getObjectByID(args[n]); if(elm) { doc.$imgSwaps[doc.$imgSwaps.length]=elm;
 elm.$src=elm.src; elm.src=args[n+1]; } }
}

function FP_preloadImgs() {//v1.0
 var d=document,a=arguments; if(!d.FP_imgs) d.FP_imgs=new Array();
 for(var i=0; i<a.length; i++) { d.FP_imgs[i]=new Image; d.FP_imgs[i].src=a[i]; }
}

function FP_getObjectByID(id,o) {//v1.0
 var c,el,els,f,m,n; if(!o)o=document; if(o.getElementById) el=o.getElementById(id);
 else if(o.layers) c=o.layers; else if(o.all) el=o.all[id]; if(el) return el;
 if(o.id==id || o.name==id) return o; if(o.childNodes) c=o.childNodes; if(c)
 for(n=0; n<c.length; n++) { el=FP_getObjectByID(id,c[n]); if(el) return el; }
 f=o.forms; if(f) for(n=0; n<f.length; n++) { els=f[n].elements;
 for(m=0; m<els.length; m++){ el=FP_getObjectByID(id,els[n]); if(el) return el; } }
 return null;
}
