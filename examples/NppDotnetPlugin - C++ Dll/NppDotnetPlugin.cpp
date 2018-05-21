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


#include "stdafx.h"
#include "PluginInterface.h"


#import "..\NppDotnetPlugin - C# Dll\NppDotnetPlugin_Cs\bin\Debug\NppDotnetPlugin_Cs.tlb" named_guids raw_interfaces_only

#pragma comment (lib, "user32.lib")

FuncItem* funcItem = NULL;


// declaration of plugins functions
void insertCurrentFullPath();
void insertCurrentFileName();
void insertCurrentDirectory();
void insertShortDateTime();
void insertLongDateTime();
void insertHtmlCloseTag();
void getFileNamesDemo();
void getSessionFileNamesDemo();
void saveCurrentSessionDemo();
void DockableDlgDemo();

// declar Dotnet Object : <namespace>::<InterfaceName>Ptr
NppDotnetPlugin_Cs::INppPluginPtr pDotNetCOMPtr = NULL;

BOOL APIENTRY DllMain( HANDLE hModule, 
                       DWORD  reasonForCall, 
                       LPVOID lpReserved
					 )
{ 
	switch (reasonForCall)
    {
	  // Here we initialize the FuncItem Array.
	  // AWARE : no need to initialize _cmdID field.
	  // This filed will be initialized by Notepad++ plugins system
      case DLL_PROCESS_ATTACH:
		{
			//load dotnet Object
			CoInitialize(NULL);   //Initialize all COM Components
    
			// CreateInstance parameters
			// e.g. CreateInstance (<namespace::CLSID_<ClassName>)
			HRESULT hRes = pDotNetCOMPtr.CreateInstance(NppDotnetPlugin_Cs::CLSID_NppPlugin);

			pDotNetCOMPtr->DllMain(reasonForCall);
		  
	    }
        break;

      case DLL_PROCESS_DETACH:
		  //uninitialize all COM objects
		    CoUninitialize (); 

			delete funcItem;

        break;

      case DLL_THREAD_ATTACH:
        break;

      case DLL_THREAD_DETACH:
        break;		  
    }

    return TRUE;
}

/*
 *--------------------------------------------------
 * The 4 extern functions are mandatory 
 * They will be called by Notepad++ plugins system 
 *--------------------------------------------------
*/

// The setInfo function gets the needed infos from Notepad++ plugins system
extern "C" __declspec(dllexport) void setInfo(NppData notpadPlusData)
{
	pDotNetCOMPtr->setInfo((NppDotnetPlugin_Cs::NppData *)&notpadPlusData);
}

// The getName function tells Notepad++ plugins system its name
extern "C" __declspec(dllexport) const char * getName()
{
	char * name = NULL;
	pDotNetCOMPtr->getName((LPSTR*)&name);
	return name;
}

// The getFuncsArray function gives Notepad++ plugins system the pointer FuncItem Array 
// and the size of this array (the number of functions)
extern "C" __declspec(dllexport) FuncItem * getFuncsArray(int *nbF)
{
	NppDotnetPlugin_Cs::FuncItem** oFunc=NULL;
	long nbFunc;

	pDotNetCOMPtr->getFuncsArray(&nbFunc,(long**)&oFunc);

	funcItem = new FuncItem[nbFunc];
	for(int i=0;i<nbFunc;i++){
		funcItem[i]._pFunc = (PFUNCPLUGINCMD)oFunc[i]->pFunc;
		strcpy_s(funcItem[i]._itemName,oFunc[i]->ItemName);
		funcItem[i]._init2Check = oFunc[i]->Init2Check!=0;
		if(&oFunc[i]->PShKey != NULL) {
			funcItem[i]._pShKey = new ShortcutKey;
			funcItem[i]._pShKey->_isAlt = oFunc[i]->PShKey.IsAlt!=0;
			funcItem[i]._pShKey->_isCtrl = oFunc[i]->PShKey.IsCtrl!=0;
			funcItem[i]._pShKey->_isShift = oFunc[i]->PShKey.IsShift!=0;
			funcItem[i]._pShKey->_key = (char)oFunc[i]->PShKey.Key; 
		} else {
			funcItem[i]._pShKey = NULL;
		}
	}

	
	*nbF = nbFunc;
	return funcItem;
}

/***
 *	messageProc()
 *
 *	This function is called, if a notification from Notepad occurs
 */
extern "C" __declspec(dllexport) void messageProc(UINT Message, WPARAM wParam, LPARAM lParam)
{
}

// If you don't need get the notification from Notepad++,
// just let it be empty.
extern "C" __declspec(dllexport) void beNotified(SCNotification *notifyCode)
{
}
