var OxO34a9=["inp_type","inp_name","inp_value","row_txt1","inp_Size","row_txt2","inp_MaxLength","row_img","inp_src","btnbrowse","row_img2","sel_Align","optNotSet","optLeft","optRight","optTexttop","optAbsMiddle","optBaseline","optAbsBottom","optBottom","optMiddle","optTop","inp_Border","row_img3","inp_width","inp_height","row_img4","inp_HSpace","inp_VSpace","row_img5","AlternateText","inp_id","row_txt3","inp_access","row_txt4","inp_index","row_chk","inp_checked","row_txt5","inp_Disabled","row_txt6","inp_Readonly","onclick","value","Name","name","id","src","type","checked","disabled","readOnly","tabIndex","","accessKey","size","maxLength","width","height","vspace","hspace","border","align","alt","text","display","style","none","password","hidden","radio","checkbox","submit","reset","button","image","className","class"];var inp_type=Window_GetElement(window,OxO34a9[0],true);var inp_name=Window_GetElement(window,OxO34a9[1],true);var inp_value=Window_GetElement(window,OxO34a9[2],true);var row_txt1=Window_GetElement(window,OxO34a9[3],true);var inp_Size=Window_GetElement(window,OxO34a9[4],true);var row_txt2=Window_GetElement(window,OxO34a9[5],true);var inp_MaxLength=Window_GetElement(window,OxO34a9[6],true);var row_img=Window_GetElement(window,OxO34a9[7],true);var inp_src=Window_GetElement(window,OxO34a9[8],true);var btnbrowse=Window_GetElement(window,OxO34a9[9],true);var row_img2=Window_GetElement(window,OxO34a9[10],true);var sel_Align=Window_GetElement(window,OxO34a9[11],true);var optNotSet=Window_GetElement(window,OxO34a9[12],true);var optLeft=Window_GetElement(window,OxO34a9[13],true);var optRight=Window_GetElement(window,OxO34a9[14],true);var optTexttop=Window_GetElement(window,OxO34a9[15],true);var optAbsMiddle=Window_GetElement(window,OxO34a9[16],true);var optBaseline=Window_GetElement(window,OxO34a9[17],true);var optAbsBottom=Window_GetElement(window,OxO34a9[18],true);var optBottom=Window_GetElement(window,OxO34a9[19],true);var optMiddle=Window_GetElement(window,OxO34a9[20],true);var optTop=Window_GetElement(window,OxO34a9[21],true);var inp_Border=Window_GetElement(window,OxO34a9[22],true);var row_img3=Window_GetElement(window,OxO34a9[23],true);var inp_width=Window_GetElement(window,OxO34a9[24],true);var inp_height=Window_GetElement(window,OxO34a9[25],true);var row_img4=Window_GetElement(window,OxO34a9[26],true);var inp_HSpace=Window_GetElement(window,OxO34a9[27],true);var inp_VSpace=Window_GetElement(window,OxO34a9[28],true);var row_img5=Window_GetElement(window,OxO34a9[29],true);var AlternateText=Window_GetElement(window,OxO34a9[30],true);var inp_id=Window_GetElement(window,OxO34a9[31],true);var row_txt3=Window_GetElement(window,OxO34a9[32],true);var inp_access=Window_GetElement(window,OxO34a9[33],true);var row_txt4=Window_GetElement(window,OxO34a9[34],true);var inp_index=Window_GetElement(window,OxO34a9[35],true);var row_chk=Window_GetElement(window,OxO34a9[36],true);var inp_checked=Window_GetElement(window,OxO34a9[37],true);var row_txt5=Window_GetElement(window,OxO34a9[38],true);var inp_Disabled=Window_GetElement(window,OxO34a9[39],true);var row_txt6=Window_GetElement(window,OxO34a9[40],true);var inp_Readonly=Window_GetElement(window,OxO34a9[41],true);btnbrowse[OxO34a9[42]]=function btnbrowse_onclick(){function Ox35d(Ox13e){if(Ox13e){inp_src[OxO34a9[43]]=Ox13e;FireUIChanged();SyncTo(element);} ;} ;editor.SetNextDialogWindow(window);if(Browser_IsSafari()){editor.ShowSelectImageDialog(Ox35d,inp_src.value,inp_src);} else {editor.ShowSelectImageDialog(Ox35d,inp_src.value);} ;} ;UpdateState=function UpdateState_Input(){} ;SyncToView=function SyncToView_Input(){if(element[OxO34a9[44]]){inp_name[OxO34a9[43]]=element[OxO34a9[44]];} ;if(element[OxO34a9[45]]){inp_name[OxO34a9[43]]=element[OxO34a9[45]];} ;inp_id[OxO34a9[43]]=element[OxO34a9[46]];inp_value[OxO34a9[43]]=(element[OxO34a9[43]]).trim();inp_src[OxO34a9[43]]=element[OxO34a9[47]];inp_type[OxO34a9[43]]=element[OxO34a9[48]];inp_checked[OxO34a9[49]]=element[OxO34a9[49]];inp_Disabled[OxO34a9[49]]=element[OxO34a9[50]];inp_Readonly[OxO34a9[49]]=element[OxO34a9[51]];if(element[OxO34a9[52]]==0){inp_index[OxO34a9[43]]=OxO34a9[53];} else {inp_index[OxO34a9[43]]=element[OxO34a9[52]];} ;if(element[OxO34a9[54]]){inp_access[OxO34a9[43]]=element[OxO34a9[54]];} ;if(element[OxO34a9[55]]){if(element[OxO34a9[55]]==20){inp_Size[OxO34a9[43]]=OxO34a9[53];} else {inp_Size[OxO34a9[43]]=element[OxO34a9[55]];} ;} ;if(element[OxO34a9[56]]){if(element[OxO34a9[56]]==2147483647||element[OxO34a9[56]]<=0){inp_MaxLength[OxO34a9[43]]=OxO34a9[53];} else {inp_MaxLength[OxO34a9[43]]=element[OxO34a9[56]];} ;} ;if(element[OxO34a9[57]]){inp_width[OxO34a9[43]]=element[OxO34a9[57]];} ;if(element[OxO34a9[58]]){inp_height[OxO34a9[43]]=element[OxO34a9[58]];} ;if(element[OxO34a9[59]]){inp_HSpace[OxO34a9[43]]=element[OxO34a9[59]];} ;if(element[OxO34a9[60]]){inp_VSpace[OxO34a9[43]]=element[OxO34a9[60]];} ;if(element[OxO34a9[61]]){inp_Border[OxO34a9[43]]=element[OxO34a9[61]];} ;if(element[OxO34a9[62]]){sel_Align[OxO34a9[43]]=element[OxO34a9[62]];} ;if(element[OxO34a9[63]]){alt[OxO34a9[43]]=element[OxO34a9[63]];} ;switch((element[OxO34a9[48]]).toLowerCase()){case OxO34a9[64]:;case OxO34a9[68]:row_img[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img2[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img3[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img4[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img5[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_chk[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];break ;;case OxO34a9[69]:row_img[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img2[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img3[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img4[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img5[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_chk[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt1[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt2[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt3[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt4[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt5[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt6[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];break ;;case OxO34a9[70]:;case OxO34a9[71]:row_img[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img2[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img3[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img4[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img5[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt1[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt2[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt6[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];break ;;case OxO34a9[72]:;case OxO34a9[73]:;case OxO34a9[74]:row_chk[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img2[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img3[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img4[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_img5[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt1[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt2[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt6[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];break ;;case OxO34a9[75]:row_chk[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt1[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt2[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];row_txt6[OxO34a9[66]][OxO34a9[65]]=OxO34a9[67];break ;;} ;} ;SyncTo=function SyncTo_Input(element){element[OxO34a9[45]]=inp_name[OxO34a9[43]];if(element[OxO34a9[44]]){element[OxO34a9[44]]=inp_name[OxO34a9[43]];} else {if(element[OxO34a9[45]]){element.removeAttribute(OxO34a9[45],0);element[OxO34a9[44]]=inp_name[OxO34a9[43]];} else {element[OxO34a9[44]]=inp_name[OxO34a9[43]];} ;} ;element[OxO34a9[46]]=inp_id[OxO34a9[43]];if(inp_src[OxO34a9[43]]){element[OxO34a9[47]]=inp_src[OxO34a9[43]];} ;element[OxO34a9[49]]=inp_checked[OxO34a9[49]];element[OxO34a9[43]]=inp_value[OxO34a9[43]];element.setAttribute(OxO34a9[43],inp_value.value);element[OxO34a9[50]]=inp_Disabled[OxO34a9[49]];element[OxO34a9[51]]=inp_Readonly[OxO34a9[49]];element[OxO34a9[54]]=inp_access[OxO34a9[43]];element[OxO34a9[52]]=inp_index[OxO34a9[43]];element[OxO34a9[56]]=inp_MaxLength[OxO34a9[43]];element[OxO34a9[57]]=inp_width[OxO34a9[43]];element[OxO34a9[58]]=inp_height[OxO34a9[43]];element[OxO34a9[59]]=inp_HSpace[OxO34a9[43]];element[OxO34a9[60]]=inp_VSpace[OxO34a9[43]];element[OxO34a9[61]]=inp_Border[OxO34a9[43]];element[OxO34a9[62]]=sel_Align[OxO34a9[43]];element[OxO34a9[63]]=AlternateText[OxO34a9[43]];try{element[OxO34a9[55]]=inp_Size[OxO34a9[43]];} catch(e){element[OxO34a9[55]]=20;} ;if(element[OxO34a9[52]]==OxO34a9[53]){element.removeAttribute(OxO34a9[52]);} ;if(element[OxO34a9[54]]==OxO34a9[53]){element.removeAttribute(OxO34a9[54]);} ;if(element[OxO34a9[56]]==OxO34a9[53]){element.removeAttribute(OxO34a9[56]);} ;if(element[OxO34a9[55]]==0){element.removeAttribute(OxO34a9[55]);} ;if(element[OxO34a9[57]]==0){element.removeAttribute(OxO34a9[57]);} ;if(element[OxO34a9[58]]==0){element.removeAttribute(OxO34a9[58]);} ;if(element[OxO34a9[60]]==OxO34a9[53]){element.removeAttribute(OxO34a9[60]);} ;if(element[OxO34a9[59]]==OxO34a9[53]){element.removeAttribute(OxO34a9[59]);} ;if(element[OxO34a9[46]]==OxO34a9[53]){element.removeAttribute(OxO34a9[46]);} ;if(element[OxO34a9[44]]==OxO34a9[53]){element.removeAttribute(OxO34a9[44]);} ;if(element[OxO34a9[63]]==OxO34a9[53]){element.removeAttribute(OxO34a9[63]);} ;if(element[OxO34a9[62]]==OxO34a9[53]){element.removeAttribute(OxO34a9[62]);} ;if(element[OxO34a9[76]]==OxO34a9[53]){element.removeAttribute(OxO34a9[77]);} ;if(element[OxO34a9[76]]==OxO34a9[53]){element.removeAttribute(OxO34a9[76]);} ;switch((element[OxO34a9[48]]).toLowerCase()){case OxO34a9[64]:;case OxO34a9[68]:;case OxO34a9[69]:;case OxO34a9[70]:;case OxO34a9[71]:;case OxO34a9[72]:;case OxO34a9[73]:;case OxO34a9[74]:element.removeAttribute(OxO34a9[58]);element.removeAttribute(OxO34a9[61]);element.removeAttribute(OxO34a9[47]);break ;;case OxO34a9[75]:break ;;} ;} ;