#NoEnv
SetWorkingDir %A_ScriptDir%
CoordMode, mouse, Screen
SendMode Input
#SingleInstance Force
SetTitleMatchMode 2
#WinActivateForce
SetControlDelay 1
SetWinDelay 0
SetKeyDelay -1
SetMouseDelay -1
SetBatchLines -1

CustomColor = FFFFFF  ; Can be any RGB color (it will be made transparent below).
Gui +LastFound +AlwaysOnTop -Caption +ToolWindow  ; +ToolWindow avoids a taskbar button and an alt-tab menu item.
Gui, Color, %CustomColor%
Gui, Font, s10  ; Set a large font size (32-point).
Gui, Add, Text, vMyText cLime, Позиция курсора включена...Ctrl+D для ОСТАНОВКИ  ; XX & YY serve to auto-size the window.
WinSet, TransColor, %CustomColor% 150
Gui, Show, x100 y400 NoActivate

^d:: ExitApp
ExitApp
return