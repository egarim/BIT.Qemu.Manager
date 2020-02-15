;#DropDB BIT.Qemu.ManagerEasyTest

#Application BIT.Qemu.ManagerWin
#Application BIT.Qemu.ManagerWeb
#IfDef BIT.Qemu.ManagerWin

*Action About...
 
*Action OK

#EndIf

#IfDef BIT.Qemu.ManagerWeb
!Action Navigation(My Details)
#EndIf
