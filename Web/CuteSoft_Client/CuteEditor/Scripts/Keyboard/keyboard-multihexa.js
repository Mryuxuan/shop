var OxO2138=["0123456789ABCDEF","0000","all","getElementById","","|","fond","\x3Cimg src=\x22Load.ashx?type=image\x26file=multiclavier.gif\x22 width=404 height=152 border=\x220\x22\x3E\x3Cbr /\x3E","sign","car","simpledia","simple","majus","\x26nbsp;","double","minus","doubledia","kb-","kb+","Delete","Clear","Back","CapsLock","Enter","Shift","\x3C|\x3C","Space","\x3E|\x3E","clavscroll(-3)","clavscroll(3)","faire(\x22del\x22)","RAZ()","faire(\x22bck\x22)","bloq()","faire(\x22\x5Cn\x22)","haut()","faire(\x22ar\x22)","faire(\x22 \x22)","faire(\x22av\x22)","act","action","clav","clavier","masque","\x3Cimg src=\x22Load.ashx?type=image\x26file=1x1.gif\x22 width=404 height=152 border=\x220\x22 usemap=\x22#clavier\x22\x3E","\x3Cmap name=\x22clavier\x22\x3E","\x3Carea coords=\x22",",","\x22 href=\x22javascript:void(0)\x22 onClick=\x27javascript:ecrire(",")\x27\x3E","\x22 href=\x22javascript:void(0)\x22 onClick=\x27javascript:","\x27\x3E","\x22 href=\x27javascript:charger(","\x3C/map\x3E","length"," ","%0D%0A","av","ar","bck","del","\x3Cspan class=","\x3E","\x3C/span\x3E","\x3Cdiv id=\x22","\x22 \x3E","\x3C/div\x3E","left","style","px","top","innerHTML","act0","act1","langue=","cookie",";","langue","=","; ","expires="];var caps=0,lock=0,hexchars=OxO2138[0],accent=OxO2138[1],clavdeb=0;var clav= new Array();j=0;for(i in Maj){clav[j]=i;j++;} ;var ns6=((!document[OxO2138[2]])&&(document[OxO2138[3]]));var ie=document[OxO2138[2]];var langue=getCk();if(langue==OxO2138[4]){langue=clav[clavdeb];} ;CarMaj=Maj[langue].split(OxO2138[5]);CarMin=Min[langue].split(OxO2138[5]);var posClavierLeft=0,posClavierTop=0;if(ns6){posClavierLeft=0;posClavierTop=80;} else {if(ie){posClavierLeft=0;posClavierTop=80;} ;} ;tracer(OxO2138[6],posClavierLeft,posClavierTop,OxO2138[7],OxO2138[8]);var posX= new Array(0,28,56,84,112,140,168,196,224,252,280,308,336,42,70,98,126,154,182,210,238,266,294,322,350,50,78,106,134,162,190,218,246,274,302,330,64,92,120,148,176,204,232,260,288,316,28,56,84,294,322,350);var posY= new Array(14,14,14,14,14,14,14,14,14,14,14,14,14,42,42,42,42,42,42,42,42,42,42,42,42,70,70,70,70,70,70,70,70,70,70,70,98,98,98,98,98,98,98,98,98,98,126,126,126,126,126,126);var nbTouches=52;for(i=0;i<nbTouches;i++){CarMaj[i]=((CarMaj[i]!=OxO2138[1])?(fromhexby4tocar(CarMaj[i])):OxO2138[4]);CarMin[i]=((CarMin[i]!=OxO2138[1])?(fromhexby4tocar(CarMin[i])):OxO2138[4]);if(CarMaj[i]==CarMin[i].toUpperCase()){cecar=((lock==0)&&(caps==0)?CarMin[i]:CarMaj[i]);tracer(OxO2138[9]+i,posClavierLeft+6+posX[i],posClavierTop+3+posY[i],cecar,((dia[hexa(cecar)]!=null)?OxO2138[10]:OxO2138[11]));tracer(OxO2138[12]+i,posClavierLeft+15+posX[i],posClavierTop+1+posY[i],OxO2138[13],OxO2138[14]);tracer(OxO2138[15]+i,posClavierLeft+3+posX[i],posClavierTop+9+posY[i],OxO2138[13],OxO2138[14]);} else {tracer(OxO2138[9]+i,posClavierLeft+6+posX[i],posClavierTop+3+posY[i],OxO2138[13],OxO2138[11]);cecar=CarMin[i];tracer(OxO2138[15]+i,posClavierLeft+3+posX[i],posClavierTop+9+posY[i],cecar,((dia[hexa(cecar)]!=null)?OxO2138[16]:OxO2138[14]));cecar=CarMaj[i];tracer(OxO2138[12]+i,posClavierLeft+15+posX[i],posClavierTop+1+posY[i],cecar,((dia[hexa(cecar)]!=null)?OxO2138[16]:OxO2138[14]));} ;} ;var actC1= new Array(0,371,364,0,378,0,358,0,344,0,112,378);var actC2= new Array(0,0,14,42,42,70,70,98,98,126,126,126);var actC3= new Array(32,403,403,39,403,47,403,61,403,25,291,403);var actC4= new Array(11,11,39,67,67,95,95,123,123,151,151,151);var act= new Array(OxO2138[17],OxO2138[18],OxO2138[19],OxO2138[20],OxO2138[21],OxO2138[22],OxO2138[23],OxO2138[24],OxO2138[24],OxO2138[25],OxO2138[26],OxO2138[27]);var effet= new Array(OxO2138[28],OxO2138[29],OxO2138[30],OxO2138[31],OxO2138[32],OxO2138[33],OxO2138[34],OxO2138[35],OxO2138[35],OxO2138[36],OxO2138[37],OxO2138[38]);var nbActions=12;for(i=0;i<nbActions;i++){tracer(OxO2138[39]+i,posClavierLeft+1+actC1[i],posClavierTop-1+actC2[i],act[i],OxO2138[40]);} ;var clavC1= new Array(35,119,203,287);var clavC2= new Array(0,0,0,0);var clavC3= new Array(116,200,284,368);var clavC4= new Array(11,11,11,11);for(i=0;i<4;i++){tracer(OxO2138[41]+i,posClavierLeft+5+clavC1[i],posClavierTop-1+clavC2[i],clav[i],OxO2138[42]);} ;tracer(OxO2138[43],posClavierLeft,posClavierTop,OxO2138[44]);document.write(OxO2138[45]);for(i=0;i<nbTouches;i++){document.write(OxO2138[46]+posX[i]+OxO2138[47]+posY[i]+OxO2138[47]+(posX[i]+25)+OxO2138[47]+(posY[i]+25)+OxO2138[48]+i+OxO2138[49]);} ;for(i=0;i<nbActions;i++){document.write(OxO2138[46]+actC1[i]+OxO2138[47]+actC2[i]+OxO2138[47]+actC3[i]+OxO2138[47]+actC4[i]+OxO2138[50]+effet[i]+OxO2138[51]);} ;for(i=0;i<4;i++){document.write(OxO2138[46]+clavC1[i]+OxO2138[47]+clavC2[i]+OxO2138[47]+clavC3[i]+OxO2138[47]+clavC4[i]+OxO2138[52]+i+OxO2138[49]);} ;document.write(OxO2138[53]);function ecrire(i){txt=rechercher()+OxO2138[5];subtxt=txt.split(OxO2138[5]);ceci=(lock==1)?CarMaj[i]:((caps==1)?CarMaj[i]:CarMin[i]);if(test(ceci)){subtxt[0]+=cardia(ceci);distinguer(false);} else {if(dia[accent]!=null&&dia[hexa(ceci)]!=null){distinguer(false);accent=hexa(ceci);distinguer(true);} else {if(dia[accent]!=null){subtxt[0]+=fromhexby4tocar(accent)+ceci;distinguer(false);} else {if(dia[hexa(ceci)]!=null){accent=hexa(ceci);distinguer(true);} else {subtxt[0]+=ceci;} ;} ;} ;} ;txt=subtxt[0]+OxO2138[5]+subtxt[1];afficher(txt);if(caps==1){caps=0;MinusMajus();} ;} ;function faire(Oxb29){txt=rechercher()+OxO2138[5];subtxt=txt.split(OxO2138[5]);l0=subtxt[0][OxO2138[54]];l1=subtxt[1][OxO2138[54]];c1=subtxt[0].substring(0,(l0-2));c2=subtxt[0].substring(0,(l0-1));c3=subtxt[1].substring(0,1);c4=subtxt[1].substring(0,2);c5=subtxt[0].substring((l0-2),l0);c6=subtxt[0].substring((l0-1),l0);c7=subtxt[1].substring(1,l1);c8=subtxt[1].substring(2,l1);if(dia[accent]!=null){if(Oxb29==OxO2138[55]){Oxb29=fromhexby4tocar(accent);} ;distinguer(false);} ;switch(Oxb29){case (OxO2138[57]):if(escape(c4)!=OxO2138[56]){txt=subtxt[0]+c3+OxO2138[5]+c7;} else {txt=subtxt[0]+c4+OxO2138[5]+c8;} ;break ;;case (OxO2138[58]):if(escape(c5)!=OxO2138[56]){txt=c2+OxO2138[5]+c6+subtxt[1];} else {txt=c1+OxO2138[5]+c5+subtxt[1];} ;break ;;case (OxO2138[59]):if(escape(c5)!=OxO2138[56]){txt=c2+OxO2138[5]+subtxt[1];} else {txt=c1+OxO2138[5]+subtxt[1];} ;break ;;case (OxO2138[60]):if(escape(c4)!=OxO2138[56]){txt=subtxt[0]+OxO2138[5]+c7;} else {txt=subtxt[0]+OxO2138[5]+c8;} ;break ;;default:txt=subtxt[0]+Oxb29+OxO2138[5]+subtxt[1];break ;;} ;afficher(txt);} ;function RAZ(){txt=OxO2138[4];if(dia[accent]!=null){distinguer(false);} ;afficher(txt);} ;function haut(){caps=1;MinusMajus();} ;function bloq(){lock=(lock==1)?0:1;MinusMajus();} ;function tracer(Oxb2e,Oxb2f,haut,Oxb29,Oxb30){Oxb29=OxO2138[61]+Oxb30+OxO2138[62]+Oxb29+OxO2138[63];document.write(OxO2138[64]+Oxb2e+OxO2138[65]+Oxb29+OxO2138[66]);if(ns6){document.getElementById(Oxb2e)[OxO2138[68]][OxO2138[67]]=Oxb2f+OxO2138[69];document.getElementById(Oxb2e)[OxO2138[68]][OxO2138[70]]=haut+OxO2138[69];} else {if(ie){document.all(Oxb2e)[OxO2138[68]][OxO2138[67]]=Oxb2f;document.all(Oxb2e)[OxO2138[68]][OxO2138[70]]=haut;} ;} ;} ;function retracer(Oxb2e,Oxb29,Oxb30){Oxb29=OxO2138[61]+Oxb30+OxO2138[62]+Oxb29+OxO2138[63];if(ns6){document.getElementById(Oxb2e)[OxO2138[71]]=Oxb29;} else {if(ie){doc=document.all(Oxb2e);doc[OxO2138[71]]=Oxb29;} ;} ;} ;function clavscroll(Ox27){clavdeb+=Ox27;if(clavdeb<0){clavdeb=0;} ;if(clavdeb>clav[OxO2138[54]]-4){clavdeb=clav[OxO2138[54]]-4;} ;for(i=clavdeb;i<clavdeb+4;i++){retracer(OxO2138[41]+(i-clavdeb),clav[i],OxO2138[42]);} ;if(clavdeb==0){retracer(OxO2138[72],OxO2138[13],OxO2138[40]);} else {retracer(OxO2138[72],act[0],OxO2138[40]);} ;if(clavdeb==clav[OxO2138[54]]-4){retracer(OxO2138[73],OxO2138[13],OxO2138[40]);} else {retracer(OxO2138[73],act[1],OxO2138[40]);} ;} ;function charger(i){langue=clav[i+clavdeb];setCk(langue);accent=OxO2138[1];CarMaj=Maj[langue].split(OxO2138[5]);CarMin=Min[langue].split(OxO2138[5]);for(i=0;i<nbTouches;i++){CarMaj[i]=((CarMaj[i]!=OxO2138[1])?(fromhexby4tocar(CarMaj[i])):OxO2138[4]);CarMin[i]=((CarMin[i]!=OxO2138[1])?(fromhexby4tocar(CarMin[i])):OxO2138[4]);if(CarMaj[i]==CarMin[i].toUpperCase()){cecar=((lock==0)&&(caps==0)?CarMin[i]:CarMaj[i]);retracer(OxO2138[9]+i,cecar,((dia[hexa(cecar)]!=null)?OxO2138[10]:OxO2138[11]));retracer(OxO2138[15]+i,OxO2138[13]);retracer(OxO2138[12]+i,OxO2138[13]);} else {retracer(OxO2138[9]+i,OxO2138[13]);cecar=CarMin[i];retracer(OxO2138[15]+i,cecar,((dia[hexa(cecar)]!=null)?OxO2138[16]:OxO2138[14]));cecar=CarMaj[i];retracer(OxO2138[12]+i,cecar,((dia[hexa(cecar)]!=null)?OxO2138[16]:OxO2138[14]));} ;} ;} ;function distinguer(Oxb35){for(i=0;i<nbTouches;i++){if(CarMaj[i]==CarMin[i].toUpperCase()){cecar=((lock==0)&&(caps==0)?CarMin[i]:CarMaj[i]);if(test(cecar)){retracer(OxO2138[9]+i,Oxb35?(cardia(cecar)):cecar,Oxb35?OxO2138[10]:OxO2138[11]);} ;} else {cecar=CarMin[i];if(test(cecar)){retracer(OxO2138[15]+i,Oxb35?(cardia(cecar)):cecar,Oxb35?OxO2138[16]:OxO2138[14]);} ;cecar=CarMaj[i];if(test(cecar)){retracer(OxO2138[12]+i,Oxb35?(cardia(cecar)):cecar,Oxb35?OxO2138[16]:OxO2138[14]);} ;} ;} ;if(!Oxb35){accent=OxO2138[1];} ;} ;function MinusMajus(){for(i=0;i<nbTouches;i++){if(CarMaj[i]==CarMin[i].toUpperCase()){cecar=((lock==0)&&(caps==0)?CarMin[i]:CarMaj[i]);retracer(OxO2138[9]+i,(test(cecar)?cardia(cecar):cecar),((dia[hexa(cecar)]!=null||test(cecar))?OxO2138[10]:OxO2138[11]));} ;} ;} ;function test(Oxb37){return (dia[accent]!=null&&dia[accent][hexa(Oxb37)]!=null);} ;function cardia(Oxb37){return (fromhexby4tocar(dia[accent][hexa(Oxb37)]));} ;function fromhex(Oxb3a){out=0;for(a=Oxb3a[OxO2138[54]]-1;a>=0;a--){out+=Math.pow(16,Oxb3a[OxO2138[54]]-a-1)*hexchars.indexOf(Oxb3a.charAt(a));} ;return out;} ;function fromhexby4tocar(Oxb29){out4= new String();for(l=0;l<Oxb29[OxO2138[54]];l+=4){out4+=String.fromCharCode(fromhex(Oxb29.substring(l,l+4)));} ;return out4;} ;function tohex(Oxb3a){return hexchars.charAt(Oxb3a/16)+hexchars.charAt(Oxb3a%16);} ;function tohex2(Oxb3a){return tohex(Oxb3a/256)+tohex(Oxb3a%256);} ;function hexa(Oxb29){out=OxO2138[4];for(k=0;k<Oxb29[OxO2138[54]];k++){out+=(tohex2(Oxb29.charCodeAt(k)));} ;return out;} ;function getCk(){fromN=document[OxO2138[75]].indexOf(OxO2138[74])+0;if((fromN)!=-1){fromN+=7;toN=document[OxO2138[75]].indexOf(OxO2138[76],fromN)+0;if(toN==-1){toN=document[OxO2138[75]][OxO2138[54]];} ;return unescape(document[OxO2138[75]].substring(fromN,toN));} ;return OxO2138[4];} ;function setCk(Oxb3a){if(Oxb3a!=null){exp= new Date();time=365*60*60*24*1000;exp.setTime(exp.getTime()+time);document[OxO2138[75]]=escape(OxO2138[77])+OxO2138[78]+escape(Oxb3a)+OxO2138[79]+OxO2138[80]+exp.toGMTString();} ;} ;