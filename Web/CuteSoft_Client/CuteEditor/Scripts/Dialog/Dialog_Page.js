var OxOedf5=["inp_title","inp_doctype","inp_description","inp_keywords","PageLanguage","HTMLEncoding","bgcolor","bgcolor_Preview","fontcolor","fontcolor_Preview","Backgroundimage","btnbrowse","TopMargin","BottomMargin","LeftMargin","RightMargin","MarginWidth","MarginHeight","btnok","btncc","editor","window","document","body","head","title","value","innerHTML","DOCTYPE","meta","length","name","keywords","content","description","httpEquiv","content-type","content-language","background","color","style","backgroundColor","bgColor","topMargin","bottomMargin","leftMargin","rightMargin","marginWidth","marginHeight","","[[ValidNumber]]","Please enter a valid color number.","text","childNodes","parentNode","http-equiv","Content-Type","Content-Language","META","onclick"];var inp_title=Window_GetElement(window,OxOedf5[0],true);var inp_doctype=Window_GetElement(window,OxOedf5[1],true);var inp_description=Window_GetElement(window,OxOedf5[2],true);var inp_keywords=Window_GetElement(window,OxOedf5[3],true);var PageLanguage=Window_GetElement(window,OxOedf5[4],true);var HTMLEncoding=Window_GetElement(window,OxOedf5[5],true);var bgcolor=Window_GetElement(window,OxOedf5[6],true);var bgcolor_Preview=Window_GetElement(window,OxOedf5[7],true);var fontcolor=Window_GetElement(window,OxOedf5[8],true);var fontcolor_Preview=Window_GetElement(window,OxOedf5[9],true);var Backgroundimage=Window_GetElement(window,OxOedf5[10],true);var btnbrowse=Window_GetElement(window,OxOedf5[11],true);var TopMargin=Window_GetElement(window,OxOedf5[12],true);var BottomMargin=Window_GetElement(window,OxOedf5[13],true);var LeftMargin=Window_GetElement(window,OxOedf5[14],true);var RightMargin=Window_GetElement(window,OxOedf5[15],true);var MarginWidth=Window_GetElement(window,OxOedf5[16],true);var MarginHeight=Window_GetElement(window,OxOedf5[17],true);var btnok=Window_GetElement(window,OxOedf5[18],true);var btncc=Window_GetElement(window,OxOedf5[19],true);var obj=Window_GetDialogArguments(window);var editor=obj[OxOedf5[20]];var editwin=obj[OxOedf5[21]];var editdoc=obj[OxOedf5[22]];var body=editdoc[OxOedf5[23]];var head=obj[OxOedf5[24]];var title=head.getElementsByTagName(OxOedf5[25])[0];if(title){inp_title[OxOedf5[26]]=title[OxOedf5[27]];} ;inp_doctype[OxOedf5[26]]=obj[OxOedf5[28]];var metas=head.getElementsByTagName(OxOedf5[29]);for(var m=0;m<metas[OxOedf5[30]];m++){if(metas[m][OxOedf5[31]].toLowerCase()==OxOedf5[32]){inp_keywords[OxOedf5[26]]=metas[m][OxOedf5[33]];} ;if(metas[m][OxOedf5[31]].toLowerCase()==OxOedf5[34]){inp_description[OxOedf5[26]]=metas[m][OxOedf5[33]];} ;if(metas[m][OxOedf5[35]].toLowerCase()==OxOedf5[36]){HTMLEncoding[OxOedf5[26]]=metas[m][OxOedf5[33]];} ;if(metas[m][OxOedf5[35]].toLowerCase()==OxOedf5[37]){PageLanguage[OxOedf5[26]]=metas[m][OxOedf5[33]];} ;} ;if(editdoc[OxOedf5[23]][OxOedf5[38]]){Backgroundimage[OxOedf5[26]]=editdoc[OxOedf5[23]][OxOedf5[38]];} ;if(editdoc[OxOedf5[23]][OxOedf5[40]][OxOedf5[39]]){fontcolor[OxOedf5[26]]=editdoc[OxOedf5[23]][OxOedf5[40]][OxOedf5[39]];fontcolor[OxOedf5[40]][OxOedf5[41]]=fontcolor[OxOedf5[26]];fontcolor_Preview[OxOedf5[40]][OxOedf5[41]]=fontcolor[OxOedf5[26]];} ;var body_bgcolor=editdoc[OxOedf5[23]][OxOedf5[40]][OxOedf5[41]]||editdoc[OxOedf5[23]][OxOedf5[42]];if(body_bgcolor){bgcolor[OxOedf5[26]]=body_bgcolor;bgcolor[OxOedf5[40]][OxOedf5[41]]=body_bgcolor;bgcolor_Preview[OxOedf5[40]][OxOedf5[41]]=body_bgcolor;} ;if(Browser_IsWinIE()){if(body[OxOedf5[43]]){TopMargin[OxOedf5[26]]=body[OxOedf5[43]];} ;if(body[OxOedf5[44]]){BottomMargin[OxOedf5[26]]=body[OxOedf5[44]];} ;if(body[OxOedf5[45]]){LeftMargin[OxOedf5[26]]=body[OxOedf5[45]];} ;if(body[OxOedf5[46]]){RightMargin[OxOedf5[26]]=body[OxOedf5[46]];} ;if(body[OxOedf5[47]]){MarginWidth[OxOedf5[26]]=body[OxOedf5[47]];} ;if(body[OxOedf5[48]]){MarginHeight[OxOedf5[26]]=body[OxOedf5[48]];} ;} else {if(body.getAttribute(OxOedf5[43])){TopMargin[OxOedf5[26]]=body.getAttribute(OxOedf5[43]);} ;if(body.getAttribute(OxOedf5[44])){BottomMargin[OxOedf5[26]]=body.getAttribute(OxOedf5[44]);} ;if(body.getAttribute(OxOedf5[45])){LeftMargin[OxOedf5[26]]=body.getAttribute(OxOedf5[45]);} ;if(body.getAttribute(OxOedf5[46])){RightMargin[OxOedf5[26]]=body.getAttribute(OxOedf5[46]);} ;if(body.getAttribute(OxOedf5[16])){MarginWidth[OxOedf5[26]]=body.getAttribute(OxOedf5[47]);} ;if(body.getAttribute(OxOedf5[48])){MarginHeight[OxOedf5[26]]=body.getAttribute(OxOedf5[48]);} ;} ;function do_insert(){try{if(Browser_IsWinIE()){body[OxOedf5[43]]=TopMargin[OxOedf5[26]];body[OxOedf5[44]]=BottomMargin[OxOedf5[26]];body[OxOedf5[45]]=LeftMargin[OxOedf5[26]];body[OxOedf5[46]]=RightMargin[OxOedf5[26]];if(MarginWidth[OxOedf5[26]]){body[OxOedf5[47]]=MarginWidth[OxOedf5[26]];} ;if(MarginHeight[OxOedf5[26]]){body[OxOedf5[48]]=MarginHeight[OxOedf5[26]];} ;} else {body.setAttribute(OxOedf5[43],TopMargin.value);body.setAttribute(OxOedf5[44],BottomMargin.value);body.setAttribute(OxOedf5[45],LeftMargin.value);body.setAttribute(OxOedf5[46],RightMargin.value);body.setAttribute(OxOedf5[47],MarginWidth.value);body.setAttribute(OxOedf5[48],MarginHeight.value);if(body.getAttribute(OxOedf5[43])==OxOedf5[49]){body.removeAttribute(OxOedf5[43]);} ;if(body.getAttribute(OxOedf5[44])==OxOedf5[49]){body.removeAttribute(OxOedf5[44]);} ;if(body.getAttribute(OxOedf5[45])==OxOedf5[49]){body.removeAttribute(OxOedf5[45]);} ;if(body.getAttribute(OxOedf5[46])==OxOedf5[49]){body.removeAttribute(OxOedf5[46]);} ;if(body.getAttribute(OxOedf5[47])==OxOedf5[49]){body.removeAttribute(OxOedf5[47]);} ;if(body.getAttribute(OxOedf5[48])==OxOedf5[49]){body.removeAttribute(OxOedf5[48]);} ;} ;} catch(er){alert(OxOedf5[50]);return ;} ;try{editdoc[OxOedf5[23]][OxOedf5[40]][OxOedf5[41]]=bgcolor[OxOedf5[26]];editdoc[OxOedf5[23]][OxOedf5[40]][OxOedf5[39]]=fontcolor[OxOedf5[26]];if(Backgroundimage[OxOedf5[26]]){editdoc[OxOedf5[23]][OxOedf5[38]]=Backgroundimage[OxOedf5[26]];} else {body.removeAttribute(OxOedf5[38]);} ;} catch(er){alert(OxOedf5[51]);return ;} ;if(!title){title=document.createElement(OxOedf5[25]);head.appendChild(title);} ;if(Browser_IsWinIE()){title[OxOedf5[52]]=inp_title[OxOedf5[26]];} else {var Ox462=document.createTextNode(inp_title.value);try{title.removeChild(title[OxOedf5[53]].item(0));} catch(x){} ;title.appendChild(Ox462);} ;for(var m=0;m<metas[OxOedf5[30]];m++){var Oxb7=metas[m];if(Oxb7){if(Oxb7[OxOedf5[31]].toLowerCase()==OxOedf5[32]||Oxb7[OxOedf5[31]].toLowerCase()==OxOedf5[34]||Oxb7[OxOedf5[31]].toLowerCase()==OxOedf5[36]||Oxb7[OxOedf5[31]].toLowerCase()==OxOedf5[37]){Oxb7[OxOedf5[54]].removeChild(Oxb7);Oxb7=null;} ;} ;} ;try{Ox463(OxOedf5[31],OxOedf5[32],inp_keywords.value);Ox463(OxOedf5[31],OxOedf5[34],inp_description.value);Ox463(OxOedf5[55],OxOedf5[56],HTMLEncoding.value);Ox463(OxOedf5[55],OxOedf5[57],PageLanguage.value);} catch(x){} ;function Ox463(Ox464,name,Oxce){var metas=head.getElementsByTagName(OxOedf5[29]);for(var m=0;m<metas[OxOedf5[30]];m++){if(metas[m][OxOedf5[31]].toLowerCase()==name.toLowerCase()){metas[m][OxOedf5[54]].removeChild(metas[m]);} ;} ;if(Oxce!=OxOedf5[49]&&Oxce!=null){var Ox465=editdoc.createElement(OxOedf5[58]);Ox465.setAttribute(Ox464,name);Ox465.setAttribute(OxOedf5[33],Oxce);head.appendChild(Ox465);} ;} ;Window_SetDialogReturnValue(window,inp_doctype[OxOedf5[26]]+OxOedf5[49]);Window_CloseDialog(window);} ;btnbrowse[OxOedf5[59]]=function btnbrowse_onclick(){function Ox35d(Ox13e){if(Ox13e){Backgroundimage[OxOedf5[26]]=Ox13e;FireUIChanged();} ;} ;editor.SetNextDialogWindow(window);if(Browser_IsSafari()){editor.ShowSelectImageDialog(Ox35d,Backgroundimage.value,Backgroundimage);} else {editor.ShowSelectImageDialog(Ox35d,Backgroundimage.value);} ;} ;function do_Close(){Window_CloseDialog(window);} ;fontcolor[OxOedf5[59]]=fontcolor_Preview[OxOedf5[59]]=function fontcolor_onclick(){SelectColor(fontcolor,fontcolor_Preview);} ;bgcolor[OxOedf5[59]]=bgcolor_Preview[OxOedf5[59]]=function bgcolor_onclick(){SelectColor(bgcolor,bgcolor_Preview);} ;