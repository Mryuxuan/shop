var OxO74aa=["ig","\x3C/?[^\x3E]*\x3E","","allhtml","\x3C\x5C?xml[^\x3E]*\x3E","\x3C/?[a-z]+:[^\x3E]*\x3E","(\x3C[^\x3E]+) class=[^ |^\x3E]*([^\x3E]*\x3E)","$1 $2","(\x3C[^\x3E]+) style=\x22[^\x22]*\x22([^\x3E]*\x3E)","\x3Cspan[^\x3E]*\x3E\x3C/span[^\x3E]*\x3E","\x3Cspan\x3E\x3Cspan\x3E","\x3Cspan\x3E","\x3C/span\x3E\x3C/span\x3E","\x3C/span\x3E","[ ]*\x3E","\x3E","word","css","\x3C/?font[^\x3E]*\x3E","font","\x3C/?span[^\x3E]*\x3E","span"];var editor=Window_GetDialogArguments(window);function execRE(Ox296,Ox297,Oxce){var Ox298= new RegExp(Ox296,OxO74aa[0]);return Oxce.replace(Ox298,Ox297);} ;function getContent(){return editor.GetBodyInnerHTML();} ;function setContent(Oxce){editor.SetHTML(Oxce);} ;function codeCleaner(Ox216){var Oxce=getContent();switch(Ox216){case OxO74aa[3]:Oxce=execRE(OxO74aa[1],OxO74aa[2],Oxce);break ;;case OxO74aa[16]:Oxce=execRE(OxO74aa[4],OxO74aa[2],Oxce);Oxce=execRE(OxO74aa[5],OxO74aa[2],Oxce);Oxce=execRE(OxO74aa[6],OxO74aa[7],Oxce);Oxce=execRE(OxO74aa[8],OxO74aa[7],Oxce);Oxce=execRE(OxO74aa[9],OxO74aa[2],Oxce);Oxce=execRE(OxO74aa[10],OxO74aa[11],Oxce);Oxce=execRE(OxO74aa[12],OxO74aa[13],Oxce);Oxce=execRE(OxO74aa[14],OxO74aa[15],Oxce);break ;;case OxO74aa[17]:Oxce=execRE(OxO74aa[6],OxO74aa[7],Oxce);Oxce=execRE(OxO74aa[8],OxO74aa[7],Oxce);break ;;case OxO74aa[19]:Oxce=execRE(OxO74aa[18],OxO74aa[2],Oxce);break ;;case OxO74aa[21]:Oxce=execRE(OxO74aa[20],OxO74aa[2],Oxce);break ;;} ;setContent(Oxce);} ;