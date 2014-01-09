Imports System
Imports System.Data
Imports System.Data.OleDb

Module Mdl_HakAksess
    Public Sub LoadAksess()
        'Frm_Menu.FILEToolStripMenuItem.Enabled = True
        Frm_Menu.MASTERToolStripMenuItem.Enabled = False
        Frm_Menu.TRANSAKSIToolStripMenuItem.Enabled = False
        Frm_Menu.LAPORANToolStripMenuItem.Enabled = False
        Frm_Menu.UTILITYToolStripMenuItem.Enabled = False
        'Frm_Menu.WINDOWSToolStripMenuItem.Enabled = True
        Frm_MENU.LogOutToolStripMenuItem.Enabled = True
    End Sub

    Public Sub operatorr()
        'Frm_Menu.FILEToolStripMenuItem.Enabled = True
        Frm_Menu.MASTERToolStripMenuItem.Enabled = False
        Frm_Menu.TRANSAKSIToolStripMenuItem.Enabled = True
        Frm_Menu.LAPORANToolStripMenuItem.Enabled = True
        Frm_Menu.UTILITYToolStripMenuItem.Enabled = False
        'Frm_Menu.WINDOWSToolStripMenuItem.Enabled = True
        Frm_MENU.LogOutToolStripMenuItem.Enabled = True
    End Sub

    Public Sub Supervisor()
        'Frm_Menu.FILEToolStripMenuItem.Enabled = True
        Frm_Menu.MASTERToolStripMenuItem.Enabled = True
        Frm_Menu.TRANSAKSIToolStripMenuItem.Enabled = True
        Frm_Menu.LAPORANToolStripMenuItem.Enabled = True
        Frm_Menu.UTILITYToolStripMenuItem.Enabled = True
        'Frm_Menu.WINDOWSToolStripMenuItem.Enabled = True
        Frm_MENU.LogOutToolStripMenuItem.Enabled = True
    End Sub
End Module
