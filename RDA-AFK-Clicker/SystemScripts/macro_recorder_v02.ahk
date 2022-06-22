#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.uytu
#SingleInstance Force ; Allow only one running instance of script.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

posX := []
posY := []
i := 0
Var:=""
recording := true
FormatTime, TimeString,, HHmmss
CoordMode, Mouse, Screen
;MyScriptDir:="Test"
;MyScriptName :="Test2"
;whatfile :="macro_" TimeString ".ahk"
; whatfile :="macro.ahk"
;MsgBox The current time and date (time first) is %whatfile%.
IniRead, mydir, config.ini, Clicker, cfgdirectory
IniRead, myfilename, config.ini, Clicker, cfgfilename
IniRead, mystopscripttext, config.ini, Clicker, cfgstopscripttext
; IniRead, myworkdir, config.ini, Clicker, cfgworkdir

TMI := 70	  ;in recording
TMR := 100  ;Replay
;MsgBox,0,res,%TMR%
MouseSpeed := 2

; SetClikerDir(dir)
; {
; 	MyScriptDir:=dir
; }
; SetFilenameScript(name)
; {
; 	MyScriptName := name
; }

^p::
MsgBox, %mydir%\%myfilename%
return
;**************
;START RECORDING
^r:: 

; TOOLTIP
CustomColor = FFFFFF  ; Can be any RGB color (it will be made transparent below).

Gui +LastFound +AlwaysOnTop -Caption +ToolWindow  ; +ToolWindow avoids a taskbar button and an alt-tab menu item.
Gui, Color, %CustomColor%
Gui, Font, s32  ; Set a large font size (32-point).
Gui, Add, Text, vMyText cLime, Идёт запись...Ctrl+D для ОСТАНОВКИ  ; XX & YY serve to auto-size the window.
WinSet, TransColor, %CustomColor% 150
Gui, Show, x100 y400 NoActivate  ; NoActivate avoids deactivating the currently active window.



recording := true
while(recording = true)
{
	
	
	if(i=0)
	{
		FileDelete, %mydir%\%myfilename%
		; `nSetWorkingDir %A_ScriptDir%cfgdirectory
		; `nIniRead, mydir, config.ini, Clicker, cfgdirectory
		; MsgBox, %A_ScriptDir%
		FileAppend, 
			(
			`n#NoEnv
			`nSetWorkingDir %mydir%
			`nCoordMode, Mouse, Screen
			`nSendMode Input
			`n#SingleInstance Force
			`nSetTitleMatchMode 2
			`n#WinActivateForce
			`nSetControlDelay 1
			`nSetWinDelay 0
			`nSetKeyDelay -1
			`nSetMouseDelay -1
			`nSetBatchLines -1
			`nCustomColor = FFFFFF  ; Can be any RGB color (it will be made transparent below).

			`nGui +LastFound +AlwaysOnTop -Caption +ToolWindow
			`nGui, Color, %CustomColor%
			`nGui, Font, s32  ; Set a large font size (32-point).
			`nGui, Add, Text, vMyText cLime, %mystopscripttext%
			`nWinSet, TransColor, %CustomColor% 150
			`nGui, Show, x100 y400 NoActivate
			`nloop:=1
			`nwhile(loop = 1)
			`n{
			), %mydir%\%myfilename% 
		; MsgBox, %A_ScriptDir%
		; run, recorde_keys.ahk
	}
	
	
	MouseGetPos, x, y, id_1, control_1
	posX[i] := x
	posY[i] := y
	

	; check click 
	if(GetKeyState("RButton", "P"))
	{
		FileAppend, 
			(
			`nMouseMove, %x%, %y%, %MouseSpeed%
			`nsleep %TMR%
			`nsleep 4
			`nClick, down Right
			`nsleep 23
			`nClick, up Right
			`nsleep 15
			), %mydir%\%myfilename%
		
	}
	if(GetKeyState("LButton", "P"))
	{
		FileAppend, 
			(
			`nMouseMove, %x%, %y%, %MouseSpeed%
			`nsleep %TMR%
			`nsleep 4
			`nClick, down
			`nsleep 23
			`nClick, up
			`nsleep 15
			), %mydir%\%myfilename%
		
	}
	
	if(GetKeyState("F", "P"))
	{
	  	FileAppend, 
			(
			`nsleep 10
			`nSend {F down}
			`nsleep 23
			`nSend {F up}
			), %mydir%\%myfilename%
	}

	if(GetKeyState("M", "P"))
	{
		FileAppend, 
			(
			`nsleep 10
			`nSend {M down}
			`nsleep 23
			`nSend {M up}
			), %mydir%\%myfilename%
	}
	
	;check mouse moves
	FileAppend, 
		(
		 `nMouseMove, %x%, %y%, %MouseSpeed%
		 `nsleep %TMR%
		), %mydir%\%myfilename%
	sleep %TMI%
	i++
}
return

;***************** NOT USED (ONLY MOUSE MOVES)************
^e:: ; replay
		recording := false
		i := 0
		l := posX.Length()
		while(i <=l)
		{
			x := posX[i]
			y := posY[i]
			MouseMove, %x%, %y%
			sleep %TMR%
			i := i+1
}

return

;************************
^d::  ;exit
recording := false


DetectHiddenWindows, On 
WinClose, %A_ScriptDir%\recorde_keys.ahk ahk_class AutoHotkey


FileAppend, 
		(
		`n}
		`n^s:: ExitApp
		`nloop:=0
		`nExitApp
		`nreturn
		), %mydir%\%myfilename%
; IniRead, mydir, config.ini, Clicker, cfgdirectory
; IniRead, myfilename, config.ini, Clicker, cfgfilename
; MsgBox, %whatfile%, %dir%\%myfilename%
; FileCopy, %whatfile%, %dir%\%myfilename%
Gui, cancel
Reload
return
;********************************