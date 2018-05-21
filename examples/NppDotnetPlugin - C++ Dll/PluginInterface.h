//this file is part of notepad++
//Copyright (C)2003 Don HO ( donho@altern.org )
//
//This program is free software; you can redistribute it and/or
//modify it under the terms of the GNU General Public License
//as published by the Free Software Foundation; either
//version 2 of the License, or (at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.

#ifndef PLUGININTERFACE_H
#define PLUGININTERFACE_H

#include "Scintilla.h"

//
//#define NOTEPADPLUS_USER   (WM_USER + 1000)
//#define	RUNCOMMAND_USER    (WM_USER + 3000)
//
//#define WM_GETCURRENTSCINTILLA  (NOTEPADPLUS_USER + 4)
//#define WM_GETCURRENTLANGTYPE  (NOTEPADPLUS_USER + 5)
//
//enum LangType {L_TXT, L_PHP , L_C, L_CPP, L_CS, L_OBJC, L_JAVA, L_RC, L_HTML, L_XML, L_MAKEFILE, L_PASCAL, L_BATCH, L_INI, L_NFO,\
//               L_USER, L_ASP, L_SQL, L_VB, L_JS, L_CSS, L_PERL, L_PYTHON, L_LUA, L_TEX, L_FORTRAN, L_BASH, L_FLASH, L_NSIS};
//
//
//const int FULL_CURRENT_PATH = 1;
//const int CURRENT_DIRECTORY = 2;
//const int FILE_NAME = 3;
//
//#define WM_GET_FULLCURRENTPATH (RUNCOMMAND_USER + FULL_CURRENT_PATH)
//#define WM_GET_CURRENTDIRECTORY (RUNCOMMAND_USER + CURRENT_DIRECTORY)
//#define WM_GET_FILENAME (RUNCOMMAND_USER + FILE_NAME)


struct NppData {
	HWND _nppHandle;
	HWND _scintillaMainHandle;
	HWND _scintillaSecondHandle;
};

struct ShortcutKey { 
	bool _isCtrl; 
	bool _isAlt; 
	bool _isShift; 
	unsigned char _key; 
};


const int itemNameMaxLen = 64;
typedef void (__cdecl * PFUNCPLUGINCMD)();
typedef struct {
	char _itemName[itemNameMaxLen];
	PFUNCPLUGINCMD _pFunc;
	int _cmdID;
	bool _init2Check;
	ShortcutKey *_pShKey;
} FuncItem;


// 5 mandatory functions for a plugins
extern "C" __declspec(dllexport) void setInfo(NppData);
extern "C" __declspec(dllexport) const char * getName();
extern "C" __declspec(dllexport) void beNotified(SCNotification *);
extern "C" __declspec(dllexport) void messageProc(UINT Message, WPARAM wParam, LPARAM lParam);
extern "C" __declspec(dllexport) FuncItem * getFuncsArray(int *);

#endif PLUGININTERFACE_H
