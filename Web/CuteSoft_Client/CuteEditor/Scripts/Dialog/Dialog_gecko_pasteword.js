var OxOa1ab=["onload","contentWindow","idSource","innerHTML","body","document","","designMode","on","contentEditable","fontFamily","style","Tahoma","fontSize","11px","color","black","background","white","length","\x22","\x3C$1$3"," ","\x26nbsp;","$1","\x3Ch$1\x3E","\x3C$1\x3E$2\x3C/$1\x3E"];var editor=Window_GetDialogArguments(window);function cancel(){Window_CloseDialog(window);} ;window[OxOa1ab[0]]=function (){var iframe=document.getElementById(OxOa1ab[2])[OxOa1ab[1]];iframe[OxOa1ab[5]][OxOa1ab[4]][OxOa1ab[3]]=OxOa1ab[6];iframe[OxOa1ab[5]][OxOa1ab[7]]=OxOa1ab[8];iframe[OxOa1ab[5]][OxOa1ab[4]][OxOa1ab[9]]=true;iframe[OxOa1ab[5]][OxOa1ab[4]][OxOa1ab[11]][OxOa1ab[10]]=OxOa1ab[12];iframe[OxOa1ab[5]][OxOa1ab[4]][OxOa1ab[11]][OxOa1ab[13]]=OxOa1ab[14];iframe[OxOa1ab[5]][OxOa1ab[4]][OxOa1ab[11]][OxOa1ab[15]]=OxOa1ab[16];iframe[OxOa1ab[5]][OxOa1ab[4]][OxOa1ab[11]][OxOa1ab[17]]=OxOa1ab[18];iframe.focus();} ;function insertContent(){var iframe=document.getElementById(OxOa1ab[2])[OxOa1ab[1]];var Oxce=iframe[OxOa1ab[5]][OxOa1ab[4]][OxOa1ab[3]];if(Oxce&&Oxce[OxOa1ab[19]]>0){editor.PasteHTML(_RemoveWord(Oxce));Window_CloseDialog(window);} ;} ;function _RemoveWord(Ox2d){Ox2d=Ox2d.replace(/<[\/]?(base|meta|link|style|font|st1|shape|path|lock|imagedata|stroke|formulas|xml|del|ins|[ovwxp]:\w+)[^>]*?>/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/\s*mso-[^:]+:[^;"]+;?/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/<!--[\s\S]*?-->/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/\s*MARGIN: 0cm 0cm 0pt\s*;/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/\s*MARGIN: 0cm 0cm 0pt\s*"/gi,OxOa1ab[20]);Ox2d=Ox2d.replace(/\s*TEXT-INDENT: 0cm\s*;/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/\s*TEXT-INDENT: 0cm\s*"/gi,OxOa1ab[20]);Ox2d=Ox2d.replace(/\s*TEXT-ALIGN: [^\s;]+;?"/gi,OxOa1ab[20]);Ox2d=Ox2d.replace(/\s*PAGE-BREAK-BEFORE: [^\s;]+;?"/gi,OxOa1ab[20]);Ox2d=Ox2d.replace(/\s*FONT-VARIANT: [^\s;]+;?"/gi,OxOa1ab[20]);Ox2d=Ox2d.replace(/\s*tab-stops:[^;"]*;?/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/\s*tab-stops:[^"]*/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/<(\w[^>]*) class=([^ |>]*)([^>]*)/gi,OxOa1ab[21]);Ox2d=Ox2d.replace(/\s*style="\s*"/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/<SPAN\s*[^>]*>\s* \s*<\/SPAN>/gi,OxOa1ab[22]);Ox2d=Ox2d.replace(/<(\w+)[^>]*\sstyle="[^"]*DISPLAY\s?:\s?none(.*?)<\/\1>/ig,OxOa1ab[6]);Ox2d=Ox2d.replace(/<span\s*[^>]*>\s*&nbsp;\s*<\/span>/gi,OxOa1ab[23]);Ox2d=Ox2d.replace(/<SPAN\s*[^>]*><\/SPAN>/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/<(\w[^>]*) lang=([^ |>]*)([^>]*)/gi,OxOa1ab[21]);Ox2d=Ox2d.replace(/<SPAN\s*>(.*?)<\/SPAN>/gi,OxOa1ab[24]);Ox2d=Ox2d.replace(/<\/?\w+:[^>]*>/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/<\!--.*?-->/g,OxOa1ab[6]);Ox2d=Ox2d.replace(/<H\d>\s*<\/H\d>/gi,OxOa1ab[6]);Ox2d=Ox2d.replace(/<(\w[^>]*) language=([^ |>]*)([^>]*)/gi,OxOa1ab[21]);Ox2d=Ox2d.replace(/<(\w[^>]*) onmouseover="([^\"]*)"([^>]*)/gi,OxOa1ab[21]);Ox2d=Ox2d.replace(/<(\w[^>]*) onmouseout="([^\"]*)"([^>]*)/gi,OxOa1ab[21]);Ox2d=Ox2d.replace(/<H(\d)([^>]*)>/gi,OxOa1ab[25]);Ox2d=Ox2d.replace(/<(H\d)><FONT[^>]*>(.*?)<\/FONT><\/\1>/gi,OxOa1ab[26]);Ox2d=Ox2d.replace(/<(H\d)><EM>(.*?)<\/EM><\/\1>/gi,OxOa1ab[26]);Ox2d=Ox2d.replace(/<a name="?OLE_LINK\d+"?>((.|[\r\n])*?)<\/a>/gi,OxOa1ab[24]);Ox2d=Ox2d.replace(/<a name="?_Hlt\d+"?>((.|[\r\n])*?)<\/a>/gi,OxOa1ab[24]);Ox2d=Ox2d.replace(/<a name="?_Toc\d+"?>((.|[\r\n])*?)<\/a>/gi,OxOa1ab[24]);return Ox2d;} ;