var OxOd7e8=["flash_preview","btnbrowse","inp_src","onclick","value","cssText","style","Movie"];var flash_preview=Window_GetElement(window,OxOd7e8[0],true);var btnbrowse=Window_GetElement(window,OxOd7e8[1],true);var inp_src=Window_GetElement(window,OxOd7e8[2],true);btnbrowse[OxOd7e8[3]]=function btnbrowse_onclick(){function Ox35d(Ox13e){if(Ox13e){inp_src[OxOd7e8[4]]=Ox13e;} ;} ;editor.SetNextDialogWindow(window);editor.ShowSelectFileDialog(Ox35d,inp_src.value);} ;UpdateState=function UpdateState_Flash(){flash_preview[OxOd7e8[6]][OxOd7e8[5]]=element[OxOd7e8[6]][OxOd7e8[5]];flash_preview.mergeAttributes(element);} ;SyncToView=function SyncToView_Flash(){inp_src[OxOd7e8[4]]=element[OxOd7e8[7]];} ;SyncTo=function SyncTo_Flash(element){element[OxOd7e8[7]]=inp_src[OxOd7e8[4]];} ;