using System;
using System.Collections.Generic;
using System.Text;

namespace NppDotnetPlugin_Cs
{
    public class NppConst
    {
        #region WinUser.h
        public static uint WM_CREATE { get { return 0x0001; } }
        public static uint WM_DESTROY { get { return 0x0002; } }
        public static uint WM_MOVE { get { return 0x0003; } }
        public static uint WM_ACTIVATE { get { return 0x0006; } }
        public static uint WM_CLOSE { get { return 0x0010; } }
        public static uint WM_QUERYENDSESSION { get { return 0x0011; } }
        public static uint WM_LBUTTONDBLCLK { get { return 0x0203; } }
        
        #endregion

        #region Win32 messages
        public static uint WM_USER { get { return 1024; } }
        
        public const ulong DLL_PROCESS_ATTACH = 1;
        public const ulong DLL_PROCESS_DETACH = 0;
        public const ulong DLL_THREAD_ATTACH = 2;
        public const ulong DLL_THREAD_DETACH = 3; 
        #endregion

        #region NPP Messages
        public static uint NOTEPADPLUS_USER { get { return WM_USER + 1000; } }
        public static uint WM_GETCURRENTSCINTILLA { get { return NOTEPADPLUS_USER + 4; } }
        public static uint WM_GETCURRENTLANGTYPE { get { return NOTEPADPLUS_USER + 5; } }
        public static uint WM_SETCURRENTLANGTYPE { get { return NOTEPADPLUS_USER + 6; } }
        public static uint WM_NBOPENFILES { get { return NOTEPADPLUS_USER + 7; } }
        public static uint ALL_OPEN_FILES { get { return 0; } }
        public static uint PRIMARY_VIEW { get { return 1; } }
        public static uint SECOND_VIEW { get { return 2; } }
        public static uint WM_GETOPENFILENAMES { get { return NOTEPADPLUS_USER + 8; } }
        public static uint WM_CANCEL_SCINTILLAKEY { get { return NOTEPADPLUS_USER + 9; } }
        public static uint WM_BIND_SCINTILLAKEY { get { return NOTEPADPLUS_USER + 10; } }
        public static uint WM_SCINTILLAKEY_MODIFIED { get { return NOTEPADPLUS_USER + 11; } }
        public static uint WM_MODELESSDIALOG { get { return NOTEPADPLUS_USER + 12; } }
        public static uint MODELESSDIALOGADD { get { return 0; } }
        public static uint MODELESSDIALOGREMOVE { get { return 1; } }
        public static uint WM_NBSESSIONFILES { get { return NOTEPADPLUS_USER + 13; } }
        public static uint WM_GETSESSIONFILES { get { return NOTEPADPLUS_USER + 14; } }
        public static uint WM_SAVESESSION { get { return NOTEPADPLUS_USER + 15; } }
        public static uint WM_SAVECURRENTSESSION { get { return NOTEPADPLUS_USER + 16; } }
        public static uint WM_GETOPENFILENAMES_PRIMARY { get { return NOTEPADPLUS_USER + 17; } }
        public static uint WM_GETOPENFILENAMES_SECOND { get { return NOTEPADPLUS_USER + 18; } }
        public static uint WM_GETPARENTOF { get { return NOTEPADPLUS_USER + 19; } }
        public static uint WM_CREATESCINTILLAHANDLE { get { return NOTEPADPLUS_USER + 20; } }
        public static uint WM_DESTROYSCINTILLAHANDLE { get { return NOTEPADPLUS_USER + 21; } }
        public static uint WM_GETNBUSERLANG { get { return NOTEPADPLUS_USER + 22; } }
        public static uint WM_GETCURRENTDOCINDEX { get { return NOTEPADPLUS_USER + 23; } }
        public static uint MAIN_VIEW { get { return 0; } }
        public static uint SUB_VIEW { get { return 1; } }
        public static uint WM_SETSTATUSBAR { get { return NOTEPADPLUS_USER + 24; } }
        public static uint STATUSBAR_DOC_TYPE { get { return 0; } }
        public static uint STATUSBAR_DOC_SIZE { get { return 1; } }
        public static uint STATUSBAR_CUR_POS { get { return 2; } }
        public static uint STATUSBAR_EOF_FORMAT { get { return 3; } }
        public static uint STATUSBAR_UNICODE_TYPE { get { return 4; } }
        public static uint STATUSBAR_TYPING_MODE { get { return 5; } }
        public static uint WM_GETMENUHANDLE { get { return NOTEPADPLUS_USER + 25; } }
        public static uint NPPPLUGINMENU { get { return 0; } }
        public static uint WM_ENCODE_SCI { get { return NOTEPADPLUS_USER + 26; } }
        public static uint WM_DECODE_SCI { get { return NOTEPADPLUS_USER + 27; } }
        public static uint WM_ACTIVATE_DOC { get { return NOTEPADPLUS_USER + 28; } }
        public static uint WM_LAUNCH_FINDINFILESDLG { get { return NOTEPADPLUS_USER + 29; } }
        public static uint WM_DMM_SHOW { get { return NOTEPADPLUS_USER + 30; } }
        public static uint WM_DMM_HIDE { get { return NOTEPADPLUS_USER + 31; } }
        public static uint WM_DMM_UPDATEDISPINFO { get { return NOTEPADPLUS_USER + 32; } }
        public static uint WM_DMM_REGASDCKDLG { get { return NOTEPADPLUS_USER + 33; } }
        public static uint WM_LOADSESSION { get { return NOTEPADPLUS_USER + 34; } }
        public static uint WM_DMM_VIEWOTHERTAB { get { return NOTEPADPLUS_USER + 35; } }
        public static uint WM_RELOADFILE { get { return NOTEPADPLUS_USER + 36; } }
        public static uint WM_SWITCHTOFILE { get { return NOTEPADPLUS_USER + 37; } }
        public static uint WM_SAVECURRENTFILE { get { return NOTEPADPLUS_USER + 38; } }
        public static uint WM_SAVEALLFILES { get { return NOTEPADPLUS_USER + 39; } }
        public static uint WM_PIMENU_CHECK { get { return NOTEPADPLUS_USER + 40; } }
        public static uint WM_ADDTOOLBARICON { get { return NOTEPADPLUS_USER + 41; } }
        public static uint WM_GETWINDOWSVERSION { get { return NOTEPADPLUS_USER + 42; } }
        public static uint NPPN_FIRST { get { return 1000; } }
        public static uint NPPN_READY { get { return NPPN_FIRST + 1; } }
        public static uint NPPN_TB_MODIFICATION { get { return NPPN_FIRST + 2; } }
        public static uint RUNCOMMAND_USER { get { return WM_USER + 3000; } }
        public static uint WM_GET_FULLCURRENTPATH { get { return RUNCOMMAND_USER + FULL_CURRENT_PATH; } }
        public static uint WM_GET_CURRENTDIRECTORY { get { return RUNCOMMAND_USER + CURRENT_DIRECTORY; } }
        public static uint WM_GET_FILENAME { get { return RUNCOMMAND_USER + FILE_NAME; } }
        public static uint WM_GET_NAMEPART { get { return RUNCOMMAND_USER + NAME_PART; } }
        public static uint WM_GET_EXTPART { get { return RUNCOMMAND_USER + EXT_PART; } }
        public static uint WM_GET_CURRENTWORD { get { return RUNCOMMAND_USER + CURRENT_WORD; } }
        public static uint WM_GET_NPPDIRECTORY { get { return RUNCOMMAND_USER + NPP_DIRECTORY; } }
        public static uint VAR_NOT_RECOGNIZED { get { return 0; } }
        public static uint FULL_CURRENT_PATH { get { return 1; } }
        public static uint CURRENT_DIRECTORY { get { return 2; } }
        public static uint FILE_NAME { get { return 3; } }
        public static uint NAME_PART { get { return 4; } }
        public static uint EXT_PART { get { return 5; } }
        public static uint CURRENT_WORD { get { return 6; } }
        public static uint NPP_DIRECTORY { get { return 7; } }



        #endregion

        #region src\MISC\PluginsManager\Notepad_plus_msgs.h
        public static uint NPPMSG { get { return (WM_USER + 1000); } }
        public static uint NPPM_SAVECURRENTFILE { get { return (NPPMSG + 38); } }
        public static uint NPPM_SAVEALLFILES { get { return (NPPMSG + 39); } }
        public static uint NPPM_MAKECURRENTBUFFERDIRTY { get { return (NPPMSG + 44); } }
        #endregion

        #region resource.h
        public static uint SCINTILLA_USER { get { return WM_USER + 2000; } }
        public static uint MACRO_USER { get { return WM_USER + 2000; } }

        public static uint WM_ISCURRENTMACRORECORDED { get { return MACRO_USER + 1; } }
        public static uint WM_MACRODLGRUNMACRO { get { return MACRO_USER + 2; } }

        public static uint NOTEPADPLUS_USER_INTERNAL { get { return WM_USER + 0000; } }
        
        public static uint NPPM_INTERNAL_USERCMDLIST_MODIFIED { get { return (NOTEPADPLUS_USER_INTERNAL + 1); } }
    //#define NPPM_INTERNAL_CMDLIST_MODIFIED          (NOTEPADPLUS_USER_INTERNAL + 2)
        public static uint NPPM_INTERNAL_MACROLIST_MODIFIED { get { return (NOTEPADPLUS_USER_INTERNAL + 3); } }
        public static uint NPPM_INTERNAL_PLUGINCMDLIST_MODIFIED { get { return (NOTEPADPLUS_USER_INTERNAL + 4); } }
    //#define NPPM_INTERNAL_CLEARSCINTILLAKEY         (NOTEPADPLUS_USER_INTERNAL + 5)
    //#define NPPM_INTERNAL_BINDSCINTILLAKEY	        (NOTEPADPLUS_USER_INTERNAL + 6)
        public static uint NPPM_INTERNAL_SCINTILLAKEYMODIFIED { get { return (NOTEPADPLUS_USER_INTERNAL + 7); } }
    //#define NPPM_INTERNAL_SCINTILLAFINFERCOLLAPSE   (NOTEPADPLUS_USER_INTERNAL + 8)
    //#define NPPM_INTERNAL_SCINTILLAFINFERUNCOLLAPSE (NOTEPADPLUS_USER_INTERNAL + 9)

        public static uint WORDSTYLE_USER { get { return (WM_USER + 5000); } }
             

        #endregion

        #region WinControls\ColourPicker\WordStyleDlg.h
        public static uint WM_UPDATESCINTILLAS { get { return (WORDSTYLE_USER + 1); } }
          
        #endregion

        #region ScintillaEditView.h

        public static uint WM_DOCK_USERDEFINE_DLG { get { return (SCINTILLA_USER + 1); } }
        public static uint WM_UNDOCK_USERDEFINE_DLG { get { return (SCINTILLA_USER + 2); } }
        public static uint WM_CLOSE_USERDEFINE_DLG { get { return (SCINTILLA_USER + 3); } }
        public static uint WM_REPLACEALL_INOPENEDDOC { get { return (SCINTILLA_USER + 6); } }
        public static uint WM_FINDALL_INOPENEDDOC { get { return (SCINTILLA_USER + 7); } }
        
              
        #endregion

        #region Scintilla Messages
        public static int INVALID_POSITION { get { return -1; } }
        public static uint SCI_START { get { return 2000; } }
        public static uint SCI_OPTIONAL_START { get { return 3000; } }
        public static uint SCI_LEXER_START { get { return 4000; } }
        public static uint SCI_ADDTEXT { get { return 2001; } }
        public static uint SCI_ADDSTYLEDTEXT { get { return 2002; } }
        public static uint SCI_INSERTTEXT { get { return 2003; } }
        public static uint SCI_CLEARALL { get { return 2004; } }
        public static uint SCI_CLEARDOCUMENTSTYLE { get { return 2005; } }
        public static uint SCI_GETLENGTH { get { return 2006; } }
        public static uint SCI_GETCHARAT { get { return 2007; } }
        public static uint SCI_GETCURRENTPOS { get { return 2008; } }
        public static uint SCI_GETANCHOR { get { return 2009; } }
        public static uint SCI_GETSTYLEAT { get { return 2010; } }
        public static uint SCI_REDO { get { return 2011; } }
        public static uint SCI_SETUNDOCOLLECTION { get { return 2012; } }
        public static uint SCI_SELECTALL { get { return 2013; } }
        public static uint SCI_SETSAVEPOINT { get { return 2014; } }
        public static uint SCI_GETSTYLEDTEXT { get { return 2015; } }
        public static uint SCI_CANREDO { get { return 2016; } }
        public static uint SCI_MARKERLINEFROMHANDLE { get { return 2017; } }
        public static uint SCI_MARKERDELETEHANDLE { get { return 2018; } }
        public static uint SCI_GETUNDOCOLLECTION { get { return 2019; } }
        public static uint SCWS_INVISIBLE { get { return 0; } }
        public static uint SCWS_VISIBLEALWAYS { get { return 1; } }
        public static uint SCWS_VISIBLEAFTERINDENT { get { return 2; } }
        public static uint SCI_GETVIEWWS { get { return 2020; } }
        public static uint SCI_SETVIEWWS { get { return 2021; } }
        public static uint SCI_POSITIONFROMPOINT { get { return 2022; } }
        public static uint SCI_POSITIONFROMPOINTCLOSE { get { return 2023; } }
        public static uint SCI_GOTOLINE { get { return 2024; } }
        public static uint SCI_GOTOPOS { get { return 2025; } }
        public static uint SCI_SETANCHOR { get { return 2026; } }
        public static uint SCI_GETCURLINE { get { return 2027; } }
        public static uint SCI_GETENDSTYLED { get { return 2028; } }
        public static uint SC_EOL_CRLF { get { return 0; } }
        public static uint SC_EOL_CR { get { return 1; } }
        public static uint SC_EOL_LF { get { return 2; } }
        public static uint SCI_CONVERTEOLS { get { return 2029; } }
        public static uint SCI_GETEOLMODE { get { return 2030; } }
        public static uint SCI_SETEOLMODE { get { return 2031; } }
        public static uint SCI_STARTSTYLING { get { return 2032; } }
        public static uint SCI_SETSTYLING { get { return 2033; } }
        public static uint SCI_GETBUFFEREDDRAW { get { return 2034; } }
        public static uint SCI_SETBUFFEREDDRAW { get { return 2035; } }
        public static uint SCI_SETTABWIDTH { get { return 2036; } }
        public static uint SCI_GETTABWIDTH { get { return 2121; } }
        public static uint SC_CP_UTF8 { get { return 65001; } }
        public static uint SC_CP_DBCS { get { return 1; } }
        public static uint SCI_SETCODEPAGE { get { return 2037; } }
        public static uint SCI_SETUSEPALETTE { get { return 2039; } }
        public static uint MARKER_MAX { get { return 31; } }
        public static uint SC_MARK_CIRCLE { get { return 0; } }
        public static uint SC_MARK_ROUNDRECT { get { return 1; } }
        public static uint SC_MARK_ARROW { get { return 2; } }
        public static uint SC_MARK_SMALLRECT { get { return 3; } }
        public static uint SC_MARK_SHORTARROW { get { return 4; } }
        public static uint SC_MARK_EMPTY { get { return 5; } }
        public static uint SC_MARK_ARROWDOWN { get { return 6; } }
        public static uint SC_MARK_MINUS { get { return 7; } }
        public static uint SC_MARK_PLUS { get { return 8; } }
        public static uint SC_MARK_VLINE { get { return 9; } }
        public static uint SC_MARK_LCORNER { get { return 10; } }
        public static uint SC_MARK_TCORNER { get { return 11; } }
        public static uint SC_MARK_BOXPLUS { get { return 12; } }
        public static uint SC_MARK_BOXPLUSCONNECTED { get { return 13; } }
        public static uint SC_MARK_BOXMINUS { get { return 14; } }
        public static uint SC_MARK_BOXMINUSCONNECTED { get { return 15; } }
        public static uint SC_MARK_LCORNERCURVE { get { return 16; } }
        public static uint SC_MARK_TCORNERCURVE { get { return 17; } }
        public static uint SC_MARK_CIRCLEPLUS { get { return 18; } }
        public static uint SC_MARK_CIRCLEPLUSCONNECTED { get { return 19; } }
        public static uint SC_MARK_CIRCLEMINUS { get { return 20; } }
        public static uint SC_MARK_CIRCLEMINUSCONNECTED { get { return 21; } }
        public static uint SC_MARK_BACKGROUND { get { return 22; } }
        public static uint SC_MARK_DOTDOTDOT { get { return 23; } }
        public static uint SC_MARK_ARROWS { get { return 24; } }
        public static uint SC_MARK_PIXMAP { get { return 25; } }
        public static uint SC_MARK_CHARACTER { get { return 10000; } }
        public static uint SC_MARKNUM_FOLDEREND { get { return 25; } }
        public static uint SC_MARKNUM_FOLDEROPENMID { get { return 26; } }
        public static uint SC_MARKNUM_FOLDERMIDTAIL { get { return 27; } }
        public static uint SC_MARKNUM_FOLDERTAIL { get { return 28; } }
        public static uint SC_MARKNUM_FOLDERSUB { get { return 29; } }
        public static uint SC_MARKNUM_FOLDER { get { return 30; } }
        public static uint SC_MARKNUM_FOLDEROPEN { get { return 31; } }
        public static uint SC_MASK_FOLDERS { get { return 0xFE000000; } }
        public static uint SCI_MARKERDEFINE { get { return 2040; } }
        public static uint SCI_MARKERSETFORE { get { return 2041; } }
        public static uint SCI_MARKERSETBACK { get { return 2042; } }
        public static uint SCI_MARKERADD { get { return 2043; } }
        public static uint SCI_MARKERDELETE { get { return 2044; } }
        public static uint SCI_MARKERDELETEALL { get { return 2045; } }
        public static uint SCI_MARKERGET { get { return 2046; } }
        public static uint SCI_MARKERNEXT { get { return 2047; } }
        public static uint SCI_MARKERPREVIOUS { get { return 2048; } }
        public static uint SCI_MARKERDEFINEPIXMAP { get { return 2049; } }
        public static uint SC_MARGIN_SYMBOL { get { return 0; } }
        public static uint SC_MARGIN_NUMBER { get { return 1; } }
        public static uint SCI_SETMARGINTYPEN { get { return 2240; } }
        public static uint SCI_GETMARGINTYPEN { get { return 2241; } }
        public static uint SCI_SETMARGINWIDTHN { get { return 2242; } }
        public static uint SCI_GETMARGINWIDTHN { get { return 2243; } }
        public static uint SCI_SETMARGINMASKN { get { return 2244; } }
        public static uint SCI_GETMARGINMASKN { get { return 2245; } }
        public static uint SCI_SETMARGINSENSITIVEN { get { return 2246; } }
        public static uint SCI_GETMARGINSENSITIVEN { get { return 2247; } }
        public static uint STYLE_DEFAULT { get { return 32; } }
        public static uint STYLE_LINENUMBER { get { return 33; } }
        public static uint STYLE_BRACELIGHT { get { return 34; } }
        public static uint STYLE_BRACEBAD { get { return 35; } }
        public static uint STYLE_CONTROLCHAR { get { return 36; } }
        public static uint STYLE_INDENTGUIDE { get { return 37; } }
        public static uint STYLE_LASTPREDEFINED { get { return 39; } }
        public static uint STYLE_MAX { get { return 127; } }
        public static uint SC_CHARSET_ANSI { get { return 0; } }
        public static uint SC_CHARSET_DEFAULT { get { return 1; } }
        public static uint SC_CHARSET_BALTIC { get { return 186; } }
        public static uint SC_CHARSET_CHINESEBIG5 { get { return 136; } }
        public static uint SC_CHARSET_EASTEUROPE { get { return 238; } }
        public static uint SC_CHARSET_GB2312 { get { return 134; } }
        public static uint SC_CHARSET_GREEK { get { return 161; } }
        public static uint SC_CHARSET_HANGUL { get { return 129; } }
        public static uint SC_CHARSET_MAC { get { return 77; } }
        public static uint SC_CHARSET_OEM { get { return 255; } }
        public static uint SC_CHARSET_RUSSIAN { get { return 204; } }
        public static uint SC_CHARSET_SHIFTJIS { get { return 128; } }
        public static uint SC_CHARSET_SYMBOL { get { return 2; } }
        public static uint SC_CHARSET_TURKISH { get { return 162; } }
        public static uint SC_CHARSET_JOHAB { get { return 130; } }
        public static uint SC_CHARSET_HEBREW { get { return 177; } }
        public static uint SC_CHARSET_ARABIC { get { return 178; } }
        public static uint SC_CHARSET_VIETNAMESE { get { return 163; } }
        public static uint SC_CHARSET_THAI { get { return 222; } }
        public static uint SCI_STYLECLEARALL { get { return 2050; } }
        public static uint SCI_STYLESETFORE { get { return 2051; } }
        public static uint SCI_STYLESETBACK { get { return 2052; } }
        public static uint SCI_STYLESETBOLD { get { return 2053; } }
        public static uint SCI_STYLESETITALIC { get { return 2054; } }
        public static uint SCI_STYLESETSIZE { get { return 2055; } }
        public static uint SCI_STYLESETFONT { get { return 2056; } }
        public static uint SCI_STYLESETEOLFILLED { get { return 2057; } }
        public static uint SCI_STYLERESETDEFAULT { get { return 2058; } }
        public static uint SCI_STYLESETUNDERLINE { get { return 2059; } }
        public static uint SC_CASE_MIXED { get { return 0; } }
        public static uint SC_CASE_UPPER { get { return 1; } }
        public static uint SC_CASE_LOWER { get { return 2; } }
        public static uint SCI_STYLESETCASE { get { return 2060; } }
        public static uint SCI_STYLESETCHARACTERSET { get { return 2066; } }
        public static uint SCI_STYLESETHOTSPOT { get { return 2409; } }
        public static uint SCI_SETSELFORE { get { return 2067; } }
        public static uint SCI_SETSELBACK { get { return 2068; } }
        public static uint SCI_SETCARETFORE { get { return 2069; } }
        public static uint SCI_ASSIGNCMDKEY { get { return 2070; } }
        public static uint SCI_CLEARCMDKEY { get { return 2071; } }
        public static uint SCI_CLEARALLCMDKEYS { get { return 2072; } }
        public static uint SCI_SETSTYLINGEX { get { return 2073; } }
        public static uint SCI_STYLESETVISIBLE { get { return 2074; } }
        public static uint SCI_GETCARETPERIOD { get { return 2075; } }
        public static uint SCI_SETCARETPERIOD { get { return 2076; } }
        public static uint SCI_SETWORDCHARS { get { return 2077; } }
        public static uint SCI_BEGINUNDOACTION { get { return 2078; } }
        public static uint SCI_ENDUNDOACTION { get { return 2079; } }
        public static uint INDIC_MAX { get { return 7; } }
        public static uint INDIC_PLAIN { get { return 0; } }
        public static uint INDIC_SQUIGGLE { get { return 1; } }
        public static uint INDIC_TT { get { return 2; } }
        public static uint INDIC_DIAGONAL { get { return 3; } }
        public static uint INDIC_STRIKE { get { return 4; } }
        public static uint INDIC_HIDDEN { get { return 5; } }
        public static uint INDIC_BOX { get { return 6; } }
        public static uint INDIC0_MASK { get { return 0x20; } }
        public static uint INDIC1_MASK { get { return 0x40; } }
        public static uint INDIC2_MASK { get { return 0x80; } }
        public static uint INDICS_MASK { get { return 0xE0; } }
        public static uint SCI_INDICSETSTYLE { get { return 2080; } }
        public static uint SCI_INDICGETSTYLE { get { return 2081; } }
        public static uint SCI_INDICSETFORE { get { return 2082; } }
        public static uint SCI_INDICGETFORE { get { return 2083; } }
        public static uint SCI_SETWHITESPACEFORE { get { return 2084; } }
        public static uint SCI_SETWHITESPACEBACK { get { return 2085; } }
        public static uint SCI_SETSTYLEBITS { get { return 2090; } }
        public static uint SCI_GETSTYLEBITS { get { return 2091; } }
        public static uint SCI_SETLINESTATE { get { return 2092; } }
        public static uint SCI_GETLINESTATE { get { return 2093; } }
        public static uint SCI_GETMAXLINESTATE { get { return 2094; } }
        public static uint SCI_GETCARETLINEVISIBLE { get { return 2095; } }
        public static uint SCI_SETCARETLINEVISIBLE { get { return 2096; } }
        public static uint SCI_GETCARETLINEBACK { get { return 2097; } }
        public static uint SCI_SETCARETLINEBACK { get { return 2098; } }
        public static uint SCI_STYLESETCHANGEABLE { get { return 2099; } }
        public static uint SCI_AUTOCSHOW { get { return 2100; } }
        public static uint SCI_AUTOCCANCEL { get { return 2101; } }
        public static uint SCI_AUTOCACTIVE { get { return 2102; } }
        public static uint SCI_AUTOCPOSSTART { get { return 2103; } }
        public static uint SCI_AUTOCCOMPLETE { get { return 2104; } }
        public static uint SCI_AUTOCSTOPS { get { return 2105; } }
        public static uint SCI_AUTOCSETSEPARATOR { get { return 2106; } }
        public static uint SCI_AUTOCGETSEPARATOR { get { return 2107; } }
        public static uint SCI_AUTOCSELECT { get { return 2108; } }
        public static uint SCI_AUTOCSETCANCELATSTART { get { return 2110; } }
        public static uint SCI_AUTOCGETCANCELATSTART { get { return 2111; } }
        public static uint SCI_AUTOCSETFILLUPS { get { return 2112; } }
        public static uint SCI_AUTOCSETCHOOSESINGLE { get { return 2113; } }
        public static uint SCI_AUTOCGETCHOOSESINGLE { get { return 2114; } }
        public static uint SCI_AUTOCSETIGNORECASE { get { return 2115; } }
        public static uint SCI_AUTOCGETIGNORECASE { get { return 2116; } }
        public static uint SCI_USERLISTSHOW { get { return 2117; } }
        public static uint SCI_AUTOCSETAUTOHIDE { get { return 2118; } }
        public static uint SCI_AUTOCGETAUTOHIDE { get { return 2119; } }
        public static uint SCI_AUTOCSETDROPRESTOFWORD { get { return 2270; } }
        public static uint SCI_AUTOCGETDROPRESTOFWORD { get { return 2271; } }
        public static uint SCI_REGISTERIMAGE { get { return 2405; } }
        public static uint SCI_CLEARREGISTEREDIMAGES { get { return 2408; } }
        public static uint SCI_AUTOCGETTYPESEPARATOR { get { return 2285; } }
        public static uint SCI_AUTOCSETTYPESEPARATOR { get { return 2286; } }
        public static uint SCI_SETINDENT { get { return 2122; } }
        public static uint SCI_GETINDENT { get { return 2123; } }
        public static uint SCI_SETUSETABS { get { return 2124; } }
        public static uint SCI_GETUSETABS { get { return 2125; } }
        public static uint SCI_SETLINEINDENTATION { get { return 2126; } }
        public static uint SCI_GETLINEINDENTATION { get { return 2127; } }
        public static uint SCI_GETLINEINDENTPOSITION { get { return 2128; } }
        public static uint SCI_GETCOLUMN { get { return 2129; } }
        public static uint SCI_SETHSCROLLBAR { get { return 2130; } }
        public static uint SCI_GETHSCROLLBAR { get { return 2131; } }
        public static uint SCI_SETINDENTATIONGUIDES { get { return 2132; } }
        public static uint SCI_GETINDENTATIONGUIDES { get { return 2133; } }
        public static uint SCI_SETHIGHLIGHTGUIDE { get { return 2134; } }
        public static uint SCI_GETHIGHLIGHTGUIDE { get { return 2135; } }
        public static uint SCI_GETLINEENDPOSITION { get { return 2136; } }
        public static uint SCI_GETCODEPAGE { get { return 2137; } }
        public static uint SCI_GETCARETFORE { get { return 2138; } }
        public static uint SCI_GETUSEPALETTE { get { return 2139; } }
        public static uint SCI_GETREADONLY { get { return 2140; } }
        public static uint SCI_SETCURRENTPOS { get { return 2141; } }
        public static uint SCI_SETSELECTIONSTART { get { return 2142; } }
        public static uint SCI_GETSELECTIONSTART { get { return 2143; } }
        public static uint SCI_SETSELECTIONEND { get { return 2144; } }
        public static uint SCI_GETSELECTIONEND { get { return 2145; } }
        public static uint SCI_SETPRINTMAGNIFICATION { get { return 2146; } }
        public static uint SCI_GETPRINTMAGNIFICATION { get { return 2147; } }
        public static uint SC_PRINT_NORMAL { get { return 0; } }
        public static uint SC_PRINT_INVERTLIGHT { get { return 1; } }
        public static uint SC_PRINT_BLACKONWHITE { get { return 2; } }
        public static uint SC_PRINT_COLOURONWHITE { get { return 3; } }
        public static uint SC_PRINT_COLOURONWHITEDEFAULTBG { get { return 4; } }
        public static uint SCI_SETPRINTCOLOURMODE { get { return 2148; } }
        public static uint SCI_GETPRINTCOLOURMODE { get { return 2149; } }
        public static uint SCFIND_WHOLEWORD { get { return 2; } }
        public static uint SCFIND_MATCHCASE { get { return 4; } }
        public static uint SCFIND_WORDSTART { get { return 0x00100000; } }
        public static uint SCFIND_REGEXP { get { return 0x00200000; } }
        public static uint SCFIND_POSIX { get { return 0x00400000; } }
        public static uint SCI_FINDTEXT { get { return 2150; } }
        public static uint SCI_FORMATRANGE { get { return 2151; } }
        public static uint SCI_GETFIRSTVISIBLELINE { get { return 2152; } }
        public static uint SCI_GETLINE { get { return 2153; } }
        public static uint SCI_GETLINECOUNT { get { return 2154; } }
        public static uint SCI_SETMARGINLEFT { get { return 2155; } }
        public static uint SCI_GETMARGINLEFT { get { return 2156; } }
        public static uint SCI_SETMARGINRIGHT { get { return 2157; } }
        public static uint SCI_GETMARGINRIGHT { get { return 2158; } }
        public static uint SCI_GETMODIFY { get { return 2159; } }
        public static uint SCI_SETSEL { get { return 2160; } }
        public static uint SCI_GETSELTEXT { get { return 2161; } }
        public static uint SCI_GETTEXTRANGE { get { return 2162; } }
        public static uint SCI_HIDESELECTION { get { return 2163; } }
        public static uint SCI_POINTXFROMPOSITION { get { return 2164; } }
        public static uint SCI_POINTYFROMPOSITION { get { return 2165; } }
        public static uint SCI_LINEFROMPOSITION { get { return 2166; } }
        public static uint SCI_POSITIONFROMLINE { get { return 2167; } }
        public static uint SCI_LINESCROLL { get { return 2168; } }
        public static uint SCI_SCROLLCARET { get { return 2169; } }
        public static uint SCI_REPLACESEL { get { return 2170; } }
        public static uint SCI_SETREADONLY { get { return 2171; } }
        public static uint SCI_NULL { get { return 2172; } }
        public static uint SCI_CANPASTE { get { return 2173; } }
        public static uint SCI_CANUNDO { get { return 2174; } }
        public static uint SCI_EMPTYUNDOBUFFER { get { return 2175; } }
        public static uint SCI_UNDO { get { return 2176; } }
        public static uint SCI_CUT { get { return 2177; } }
        public static uint SCI_COPY { get { return 2178; } }
        public static uint SCI_PASTE { get { return 2179; } }
        public static uint SCI_CLEAR { get { return 2180; } }
        public static uint SCI_SETTEXT { get { return 2181; } }
        public static uint SCI_GETTEXT { get { return 2182; } }
        public static uint SCI_GETTEXTLENGTH { get { return 2183; } }
        public static uint SCI_GETDIRECTFUNCTION { get { return 2184; } }
        public static uint SCI_GETDIRECTPOINTER { get { return 2185; } }
        public static uint SCI_SETOVERTYPE { get { return 2186; } }
        public static uint SCI_GETOVERTYPE { get { return 2187; } }
        public static uint SCI_SETCARETWIDTH { get { return 2188; } }
        public static uint SCI_GETCARETWIDTH { get { return 2189; } }
        public static uint SCI_SETTARGETSTART { get { return 2190; } }
        public static uint SCI_GETTARGETSTART { get { return 2191; } }
        public static uint SCI_SETTARGETEND { get { return 2192; } }
        public static uint SCI_GETTARGETEND { get { return 2193; } }
        public static uint SCI_REPLACETARGET { get { return 2194; } }
        public static uint SCI_REPLACETARGETRE { get { return 2195; } }
        public static uint SCI_SEARCHINTARGET { get { return 2197; } }
        public static uint SCI_SETSEARCHFLAGS { get { return 2198; } }
        public static uint SCI_GETSEARCHFLAGS { get { return 2199; } }
        public static uint SCI_CALLTIPSHOW { get { return 2200; } }
        public static uint SCI_CALLTIPCANCEL { get { return 2201; } }
        public static uint SCI_CALLTIPACTIVE { get { return 2202; } }
        public static uint SCI_CALLTIPPOSSTART { get { return 2203; } }
        public static uint SCI_CALLTIPSETHLT { get { return 2204; } }
        public static uint SCI_CALLTIPSETBACK { get { return 2205; } }
        public static uint SCI_CALLTIPSETFORE { get { return 2206; } }
        public static uint SCI_CALLTIPSETFOREHLT { get { return 2207; } }
        public static uint SCI_VISIBLEFROMDOCLINE { get { return 2220; } }
        public static uint SCI_DOCLINEFROMVISIBLE { get { return 2221; } }
        public static uint SC_FOLDLEVELBASE { get { return 0x400; } }
        public static uint SC_FOLDLEVELWHITEFLAG { get { return 0x1000; } }
        public static uint SC_FOLDLEVELHEADERFLAG { get { return 0x2000; } }
        public static uint SC_FOLDLEVELBOXHEADERFLAG { get { return 0x4000; } }
        public static uint SC_FOLDLEVELBOXFOOTERFLAG { get { return 0x8000; } }
        public static uint SC_FOLDLEVELCONTRACTED { get { return 0x10000; } }
        public static uint SC_FOLDLEVELUNINDENT { get { return 0x20000; } }
        public static uint SC_FOLDLEVELNUMBERMASK { get { return 0x0FFF; } }
        public static uint SCI_SETFOLDLEVEL { get { return 2222; } }
        public static uint SCI_GETFOLDLEVEL { get { return 2223; } }
        public static uint SCI_GETLASTCHILD { get { return 2224; } }
        public static uint SCI_GETFOLDPARENT { get { return 2225; } }
        public static uint SCI_SHOWLINES { get { return 2226; } }
        public static uint SCI_HIDELINES { get { return 2227; } }
        public static uint SCI_GETLINEVISIBLE { get { return 2228; } }
        public static uint SCI_SETFOLDEXPANDED { get { return 2229; } }
        public static uint SCI_GETFOLDEXPANDED { get { return 2230; } }
        public static uint SCI_TOGGLEFOLD { get { return 2231; } }
        public static uint SCI_ENSUREVISIBLE { get { return 2232; } }
        public static uint SC_FOLDFLAG_LINEBEFORE_EXPANDED { get { return 0x0002; } }
        public static uint SC_FOLDFLAG_LINEBEFORE_CONTRACTED { get { return 0x0004; } }
        public static uint SC_FOLDFLAG_LINEAFTER_EXPANDED { get { return 0x0008; } }
        public static uint SC_FOLDFLAG_LINEAFTER_CONTRACTED { get { return 0x0010; } }
        public static uint SC_FOLDFLAG_LEVELNUMBERS { get { return 0x0040; } }
        public static uint SC_FOLDFLAG_BOX { get { return 0x0001; } }
        public static uint SCI_SETFOLDFLAGS { get { return 2233; } }
        public static uint SCI_ENSUREVISIBLEENFORCEPOLICY { get { return 2234; } }
        public static uint SCI_SETTABINDENTS { get { return 2260; } }
        public static uint SCI_GETTABINDENTS { get { return 2261; } }
        public static uint SCI_SETBACKSPACEUNINDENTS { get { return 2262; } }
        public static uint SCI_GETBACKSPACEUNINDENTS { get { return 2263; } }
        public static uint SC_TIME_FOREVER { get { return 10000000; } }
        public static uint SCI_SETMOUSEDWELLTIME { get { return 2264; } }
        public static uint SCI_GETMOUSEDWELLTIME { get { return 2265; } }
        public static uint SCI_WORDSTARTPOSITION { get { return 2266; } }
        public static uint SCI_WORDENDPOSITION { get { return 2267; } }
        public static uint SC_WRAP_NONE { get { return 0; } }
        public static uint SC_WRAP_WORD { get { return 1; } }
        public static uint SCI_SETWRAPMODE { get { return 2268; } }
        public static uint SCI_GETWRAPMODE { get { return 2269; } }
        public static uint SC_WRAPVISUALFLAG_NONE { get { return 0x0000; } }
        public static uint SC_WRAPVISUALFLAG_END { get { return 0x0001; } }
        public static uint SC_WRAPVISUALFLAG_START { get { return 0x0002; } }
        public static uint SCI_SETWRAPVISUALFLAGS { get { return 2460; } }
        public static uint SCI_GETWRAPVISUALFLAGS { get { return 2461; } }
        public static uint SC_WRAPVISUALFLAGLOC_DEFAULT { get { return 0x0000; } }
        public static uint SC_WRAPVISUALFLAGLOC_END_BY_TEXT { get { return 0x0001; } }
        public static uint SC_WRAPVISUALFLAGLOC_START_BY_TEXT { get { return 0x0002; } }
        public static uint SCI_SETWRAPVISUALFLAGSLOCATION { get { return 2462; } }
        public static uint SCI_GETWRAPVISUALFLAGSLOCATION { get { return 2463; } }
        public static uint SCI_SETWRAPSTARTINDENT { get { return 2464; } }
        public static uint SCI_GETWRAPSTARTINDENT { get { return 2465; } }
        public static uint SC_CACHE_NONE { get { return 0; } }
        public static uint SC_CACHE_CARET { get { return 1; } }
        public static uint SC_CACHE_PAGE { get { return 2; } }
        public static uint SC_CACHE_DOCUMENT { get { return 3; } }
        public static uint SCI_SETLAYOUTCACHE { get { return 2272; } }
        public static uint SCI_GETLAYOUTCACHE { get { return 2273; } }
        public static uint SCI_SETSCROLLWIDTH { get { return 2274; } }
        public static uint SCI_GETSCROLLWIDTH { get { return 2275; } }
        public static uint SCI_TEXTWIDTH { get { return 2276; } }
        public static uint SCI_SETENDATLASTLINE { get { return 2277; } }
        public static uint SCI_GETENDATLASTLINE { get { return 2278; } }
        public static uint SCI_TEXTHEIGHT { get { return 2279; } }
        public static uint SCI_SETVSCROLLBAR { get { return 2280; } }
        public static uint SCI_GETVSCROLLBAR { get { return 2281; } }
        public static uint SCI_APPENDTEXT { get { return 2282; } }
        public static uint SCI_GETTWOPHASEDRAW { get { return 2283; } }
        public static uint SCI_SETTWOPHASEDRAW { get { return 2284; } }
        public static uint SCI_TARGETFROMSELECTION { get { return 2287; } }
        public static uint SCI_LINESJOIN { get { return 2288; } }
        public static uint SCI_LINESSPLIT { get { return 2289; } }
        public static uint SCI_SETFOLDMARGINCOLOUR { get { return 2290; } }
        public static uint SCI_SETFOLDMARGINHICOLOUR { get { return 2291; } }
        public static uint SCI_LINEDOWN { get { return 2300; } }
        public static uint SCI_LINEDOWNEXTEND { get { return 2301; } }
        public static uint SCI_LINEUP { get { return 2302; } }
        public static uint SCI_LINEUPEXTEND { get { return 2303; } }
        public static uint SCI_CHARLEFT { get { return 2304; } }
        public static uint SCI_CHARLEFTEXTEND { get { return 2305; } }
        public static uint SCI_CHARRIGHT { get { return 2306; } }
        public static uint SCI_CHARRIGHTEXTEND { get { return 2307; } }
        public static uint SCI_WORDLEFT { get { return 2308; } }
        public static uint SCI_WORDLEFTEXTEND { get { return 2309; } }
        public static uint SCI_WORDRIGHT { get { return 2310; } }
        public static uint SCI_WORDRIGHTEXTEND { get { return 2311; } }
        public static uint SCI_HOME { get { return 2312; } }
        public static uint SCI_HOMEEXTEND { get { return 2313; } }
        public static uint SCI_LINEEND { get { return 2314; } }
        public static uint SCI_LINEENDEXTEND { get { return 2315; } }
        public static uint SCI_DOCUMENTSTART { get { return 2316; } }
        public static uint SCI_DOCUMENTSTARTEXTEND { get { return 2317; } }
        public static uint SCI_DOCUMENTEND { get { return 2318; } }
        public static uint SCI_DOCUMENTENDEXTEND { get { return 2319; } }
        public static uint SCI_PAGEUP { get { return 2320; } }
        public static uint SCI_PAGEUPEXTEND { get { return 2321; } }
        public static uint SCI_PAGEDOWN { get { return 2322; } }
        public static uint SCI_PAGEDOWNEXTEND { get { return 2323; } }
        public static uint SCI_EDITTOGGLEOVERTYPE { get { return 2324; } }
        public static uint SCI_CANCEL { get { return 2325; } }
        public static uint SCI_DELETEBACK { get { return 2326; } }
        public static uint SCI_TAB { get { return 2327; } }
        public static uint SCI_BACKTAB { get { return 2328; } }
        public static uint SCI_NEWLINE { get { return 2329; } }
        public static uint SCI_FORMFEED { get { return 2330; } }
        public static uint SCI_VCHOME { get { return 2331; } }
        public static uint SCI_VCHOMEEXTEND { get { return 2332; } }
        public static uint SCI_ZOOMIN { get { return 2333; } }
        public static uint SCI_ZOOMOUT { get { return 2334; } }
        public static uint SCI_DELWORDLEFT { get { return 2335; } }
        public static uint SCI_DELWORDRIGHT { get { return 2336; } }
        public static uint SCI_LINECUT { get { return 2337; } }
        public static uint SCI_LINEDELETE { get { return 2338; } }
        public static uint SCI_LINETRANSPOSE { get { return 2339; } }
        public static uint SCI_LINEDUPLICATE { get { return 2404; } }
        public static uint SCI_LOWERCASE { get { return 2340; } }
        public static uint SCI_UPPERCASE { get { return 2341; } }
        public static uint SCI_LINESCROLLDOWN { get { return 2342; } }
        public static uint SCI_LINESCROLLUP { get { return 2343; } }
        public static uint SCI_DELETEBACKNOTLINE { get { return 2344; } }
        public static uint SCI_HOMEDISPLAY { get { return 2345; } }
        public static uint SCI_HOMEDISPLAYEXTEND { get { return 2346; } }
        public static uint SCI_LINEENDDISPLAY { get { return 2347; } }
        public static uint SCI_LINEENDDISPLAYEXTEND { get { return 2348; } }
        public static uint SCI_HOMEWRAP { get { return 2349; } }
        public static uint SCI_HOMEWRAPEXTEND { get { return 2450; } }
        public static uint SCI_LINEENDWRAP { get { return 2451; } }
        public static uint SCI_LINEENDWRAPEXTEND { get { return 2452; } }
        public static uint SCI_VCHOMEWRAP { get { return 2453; } }
        public static uint SCI_VCHOMEWRAPEXTEND { get { return 2454; } }
        public static uint SCI_LINECOPY { get { return 2455; } }
        public static uint SCI_MOVECARETINSIDEVIEW { get { return 2401; } }
        public static uint SCI_LINELENGTH { get { return 2350; } }
        public static uint SCI_BRACEHIGHLIGHT { get { return 2351; } }
        public static uint SCI_BRACEBADLIGHT { get { return 2352; } }
        public static uint SCI_BRACEMATCH { get { return 2353; } }
        public static uint SCI_GETVIEWEOL { get { return 2355; } }
        public static uint SCI_SETVIEWEOL { get { return 2356; } }
        public static uint SCI_GETDOCPOINTER { get { return 2357; } }
        public static uint SCI_SETDOCPOINTER { get { return 2358; } }
        public static uint SCI_SETMODEVENTMASK { get { return 2359; } }
        public static uint EDGE_NONE { get { return 0; } }
        public static uint EDGE_LINE { get { return 1; } }
        public static uint EDGE_BACKGROUND { get { return 2; } }
        public static uint SCI_GETEDGECOLUMN { get { return 2360; } }
        public static uint SCI_SETEDGECOLUMN { get { return 2361; } }
        public static uint SCI_GETEDGEMODE { get { return 2362; } }
        public static uint SCI_SETEDGEMODE { get { return 2363; } }
        public static uint SCI_GETEDGECOLOUR { get { return 2364; } }
        public static uint SCI_SETEDGECOLOUR { get { return 2365; } }
        public static uint SCI_SEARCHANCHOR { get { return 2366; } }
        public static uint SCI_SEARCHNEXT { get { return 2367; } }
        public static uint SCI_SEARCHPREV { get { return 2368; } }
        public static uint SCI_LINESONSCREEN { get { return 2370; } }
        public static uint SCI_USEPOPUP { get { return 2371; } }
        public static uint SCI_SELECTIONISRECTANGLE { get { return 2372; } }
        public static uint SCI_SETZOOM { get { return 2373; } }
        public static uint SCI_GETZOOM { get { return 2374; } }
        public static uint SCI_CREATEDOCUMENT { get { return 2375; } }
        public static uint SCI_ADDREFDOCUMENT { get { return 2376; } }
        public static uint SCI_RELEASEDOCUMENT { get { return 2377; } }
        public static uint SCI_GETMODEVENTMASK { get { return 2378; } }
        public static uint SCI_SETFOCUS { get { return 2380; } }
        public static uint SCI_GETFOCUS { get { return 2381; } }
        public static uint SCI_SETSTATUS { get { return 2382; } }
        public static uint SCI_GETSTATUS { get { return 2383; } }
        public static uint SCI_SETMOUSEDOWNCAPTURES { get { return 2384; } }
        public static uint SCI_GETMOUSEDOWNCAPTURES { get { return 2385; } }
        public static int SC_CURSORNORMAL { get { return -1; } }
        public static uint SC_CURSORWAIT { get { return 4; } }
        public static uint SCI_SETCURSOR { get { return 2386; } }
        public static uint SCI_GETCURSOR { get { return 2387; } }
        public static uint SCI_SETCONTROLCHARSYMBOL { get { return 2388; } }
        public static uint SCI_GETCONTROLCHARSYMBOL { get { return 2389; } }
        public static uint SCI_WORDPARTLEFT { get { return 2390; } }
        public static uint SCI_WORDPARTLEFTEXTEND { get { return 2391; } }
        public static uint SCI_WORDPARTRIGHT { get { return 2392; } }
        public static uint SCI_WORDPARTRIGHTEXTEND { get { return 2393; } }
        public static uint VISIBLE_SLOP { get { return 0x01; } }
        public static uint VISIBLE_STRICT { get { return 0x04; } }
        public static uint SCI_SETVISIBLEPOLICY { get { return 2394; } }
        public static uint SCI_DELLINELEFT { get { return 2395; } }
        public static uint SCI_DELLINERIGHT { get { return 2396; } }
        public static uint SCI_SETXOFFSET { get { return 2397; } }
        public static uint SCI_GETXOFFSET { get { return 2398; } }
        public static uint SCI_CHOOSECARETX { get { return 2399; } }
        public static uint SCI_GRABFOCUS { get { return 2400; } }
        public static uint CARET_SLOP { get { return 0x01; } }
        public static uint CARET_STRICT { get { return 0x04; } }
        public static uint CARET_JUMPS { get { return 0x10; } }
        public static uint CARET_EVEN { get { return 0x08; } }
        public static uint SCI_SETXCARETPOLICY { get { return 2402; } }
        public static uint SCI_SETYCARETPOLICY { get { return 2403; } }
        public static uint SCI_SETPRINTWRAPMODE { get { return 2406; } }
        public static uint SCI_GETPRINTWRAPMODE { get { return 2407; } }
        public static uint SCI_SETHOTSPOTACTIVEFORE { get { return 2410; } }
        public static uint SCI_SETHOTSPOTACTIVEBACK { get { return 2411; } }
        public static uint SCI_SETHOTSPOTACTIVEUNDERLINE { get { return 2412; } }
        public static uint SCI_SETHOTSPOTSINGLELINE { get { return 2421; } }
        public static uint SCI_PARADOWN { get { return 2413; } }
        public static uint SCI_PARADOWNEXTEND { get { return 2414; } }
        public static uint SCI_PARAUP { get { return 2415; } }
        public static uint SCI_PARAUPEXTEND { get { return 2416; } }
        public static uint SCI_POSITIONBEFORE { get { return 2417; } }
        public static uint SCI_POSITIONAFTER { get { return 2418; } }
        public static uint SCI_COPYRANGE { get { return 2419; } }
        public static uint SCI_COPYTEXT { get { return 2420; } }
        public static uint SC_SEL_STREAM { get { return 0; } }
        public static uint SC_SEL_RECTANGLE { get { return 1; } }
        public static uint SC_SEL_LINES { get { return 2; } }
        public static uint SCI_SETSELECTIONMODE { get { return 2422; } }
        public static uint SCI_GETSELECTIONMODE { get { return 2423; } }
        public static uint SCI_GETLINESELSTARTPOSITION { get { return 2424; } }
        public static uint SCI_GETLINESELENDPOSITION { get { return 2425; } }
        public static uint SCI_LINEDOWNRECTEXTEND { get { return 2426; } }
        public static uint SCI_LINEUPRECTEXTEND { get { return 2427; } }
        public static uint SCI_CHARLEFTRECTEXTEND { get { return 2428; } }
        public static uint SCI_CHARRIGHTRECTEXTEND { get { return 2429; } }
        public static uint SCI_HOMERECTEXTEND { get { return 2430; } }
        public static uint SCI_VCHOMERECTEXTEND { get { return 2431; } }
        public static uint SCI_LINEENDRECTEXTEND { get { return 2432; } }
        public static uint SCI_PAGEUPRECTEXTEND { get { return 2433; } }
        public static uint SCI_PAGEDOWNRECTEXTEND { get { return 2434; } }
        public static uint SCI_STUTTEREDPAGEUP { get { return 2435; } }
        public static uint SCI_STUTTEREDPAGEUPEXTEND { get { return 2436; } }
        public static uint SCI_STUTTEREDPAGEDOWN { get { return 2437; } }
        public static uint SCI_STUTTEREDPAGEDOWNEXTEND { get { return 2438; } }
        public static uint SCI_WORDLEFTEND { get { return 2439; } }
        public static uint SCI_WORDLEFTENDEXTEND { get { return 2440; } }
        public static uint SCI_WORDRIGHTEND { get { return 2441; } }
        public static uint SCI_WORDRIGHTENDEXTEND { get { return 2442; } }
        public static uint SCI_SETWHITESPACECHARS { get { return 2443; } }
        public static uint SCI_SETCHARSDEFAULT { get { return 2444; } }
        public static uint SCI_AUTOCGETCURRENT { get { return 2445; } }
        public static uint SCI_ALLOCATE { get { return 2446; } }
        public static uint SCI_STARTRECORD { get { return 3001; } }
        public static uint SCI_STOPRECORD { get { return 3002; } }
        public static uint SCI_SETLEXER { get { return 4001; } }
        public static uint SCI_GETLEXER { get { return 4002; } }
        public static uint SCI_COLOURISE { get { return 4003; } }
        public static uint SCI_SETPROPERTY { get { return 4004; } }
        public static uint KEYWORDSET_MAX { get { return 8; } }
        public static uint SCI_SETKEYWORDS { get { return 4005; } }
        public static uint SCI_SETLEXERLANGUAGE { get { return 4006; } }
        public static uint SCI_LOADLEXERLIBRARY { get { return 4007; } }
        public static uint SC_MOD_INSERTTEXT { get { return 0x1; } }
        public static uint SC_MOD_DELETETEXT { get { return 0x2; } }
        public static uint SC_MOD_CHANGESTYLE { get { return 0x4; } }
        public static uint SC_MOD_CHANGEFOLD { get { return 0x8; } }
        public static uint SC_PERFORMED_USER { get { return 0x10; } }
        public static uint SC_PERFORMED_UNDO { get { return 0x20; } }
        public static uint SC_PERFORMED_REDO { get { return 0x40; } }
        public static uint SC_LASTSTEPINUNDOREDO { get { return 0x100; } }
        public static uint SC_MOD_CHANGEMARKER { get { return 0x200; } }
        public static uint SC_MOD_BEFOREINSERT { get { return 0x400; } }
        public static uint SC_MOD_BEFOREDELETE { get { return 0x800; } }
        public static uint SC_MODEVENTMASKALL { get { return 0xF77; } }
        public static uint SCEN_CHANGE { get { return 768; } }
        public static uint SCEN_SETFOCUS { get { return 512; } }
        public static uint SCEN_KILLFOCUS { get { return 256; } }
        public static uint SCK_DOWN { get { return 300; } }
        public static uint SCK_UP { get { return 301; } }
        public static uint SCK_LEFT { get { return 302; } }
        public static uint SCK_RIGHT { get { return 303; } }
        public static uint SCK_HOME { get { return 304; } }
        public static uint SCK_END { get { return 305; } }
        public static uint SCK_PRIOR { get { return 306; } }
        public static uint SCK_NEXT { get { return 307; } }
        public static uint SCK_DELETE { get { return 308; } }
        public static uint SCK_INSERT { get { return 309; } }
        public static uint SCK_ESCAPE { get { return 7; } }
        public static uint SCK_BACK { get { return 8; } }
        public static uint SCK_TAB { get { return 9; } }
        public static uint SCK_RETURN { get { return 13; } }
        public static uint SCK_ADD { get { return 310; } }
        public static uint SCK_SUBTRACT { get { return 311; } }
        public static uint SCK_DIVIDE { get { return 312; } }
        public static uint SCMOD_SHIFT { get { return 1; } }
        public static uint SCMOD_CTRL { get { return 2; } }
        public static uint SCMOD_ALT { get { return 4; } }
        public static uint SCN_STYLENEEDED { get { return 2000; } }
        public static uint SCN_CHARADDED { get { return 2001; } }
        public static uint SCN_SAVEPOINTREACHED { get { return 2002; } }
        public static uint SCN_SAVEPOINTLEFT { get { return 2003; } }
        public static uint SCN_MODIFYATTEMPTRO { get { return 2004; } }
        public static uint SCN_KEY { get { return 2005; } }
        public static uint SCN_DOUBLECLICK { get { return 2006; } }
        public static uint SCN_UPDATEUI { get { return 2007; } }
        public static uint SCN_MODIFIED { get { return 2008; } }
        public static uint SCN_MACRORECORD { get { return 2009; } }
        public static uint SCN_MARGINCLICK { get { return 2010; } }
        public static uint SCN_NEEDSHOWN { get { return 2011; } }
        public static uint SCN_PAINTED { get { return 2013; } }
        public static uint SCN_USERLISTSELECTION { get { return 2014; } }
        public static uint SCN_URIDROPPED { get { return 2015; } }
        public static uint SCN_DWELLSTART { get { return 2016; } }
        public static uint SCN_DWELLEND { get { return 2017; } }
        public static uint SCN_ZOOM { get { return 2018; } }
        public static uint SCN_HOTSPOTCLICK { get { return 2019; } }
        public static uint SCN_HOTSPOTDOUBLECLICK { get { return 2020; } }
        public static uint SCN_CALLTIPCLICK { get { return 2021; } }

        #endregion
    }

    public enum LangType {L_TXT, L_PHP , L_C, L_CPP, L_CS, L_OBJC, L_JAVA, L_RC,
			   L_HTML, L_XML, L_MAKEFILE, L_PASCAL, L_BATCH, L_INI, L_NFO, L_USER,
			   L_ASP, L_SQL, L_VB, L_JS, L_CSS, L_PERL, L_PYTHON, L_LUA,
			   L_TEX, L_FORTRAN, L_BASH, L_FLASH, L_NSIS, L_TCL, L_LISP, L_SCHEME,
			   L_ASM, L_DIFF, L_PROPS, L_PS, L_RUBY, L_SMALLTALK, L_VHDL, L_KIX, L_AU3,
			   L_CAML, L_ADA, L_VERILOG, L_MATLAB, L_HASKELL, L_INNO,
			   // The end of enumated language type, so it should be always at the end
			   L_END};

    public enum winVer { WV_UNKNOWN, WV_WIN32S, WV_95, WV_98, WV_ME, WV_NT, WV_W2K, WV_XP, WV_S2003, WV_XPX64, WV_VISTA };

}
