
'Plateaux
Dim WithEvents inhibition_plateau_1_16_Var As Variable
Dim WithEvents inhibition_plateau_17_32_Var As Variable

Dim WithEvents plateau_fini_1_16_Var As Variable
Dim WithEvents plateau_fini_17_32_Var As Variable
Dim WithEvents changer_plateau_1_16_Var As Variable
Dim WithEvents changer_plateau_17_32_Var As Variable


'Cuves
Dim WithEvents Cmde_Couv_Cuve_Var As Variable
Dim WithEvents Cmde_Agit_Cuve_Var As Variable

Dim WithEvents Etat_Couv_Cuve_Var As Variable
Dim WithEvents Etat_Agit_Cuve_Var As Variable
Dim WithEvents Etat_IBC_Cuve_Var As Variable

Dim WithEvents Cmde_Agit_IBC_Var As Variable

'Dim WithEvents Presence_Cuve_Var As Variable

'E4 general
Dim WithEvents API_Pcvue_echange_1_Var As Variable
Dim WithEvents Pcvue_API_echange_1_Var As Variable

'R1
Dim WithEvents PCVUE_Etat_R1_Var As Variable
Dim WithEvents Etat_R1_Var As Variable
Dim WithEvents Cmd_R1_Var As Variable
Dim WithEvents R1_Etat_prehenseur_Var As Variable
'R2
Dim WithEvents PCVUE_Etat_R2_Var As Variable
Dim WithEvents Etat_R2_Var As Variable
Dim WithEvents Cmd_R2_Var As Variable
Dim WithEvents R2_Etat_prehenseur_Var As Variable
Dim plateau_R2 As Double
'R3
Dim WithEvents PCVUE_Etat_R3_Var As Variable
Dim WithEvents Etat_R3_Var As Variable
Dim WithEvents Cmd_R3_Var As Variable
Dim WithEvents R3_Etat_prehenseur_Var As Variable
Dim plateau_R3 As Double
'R4
Dim WithEvents PCVUE_Etat_R4_Var As Variable
Dim WithEvents Etat_R4_Var As Variable
Dim WithEvents Cmd_R4_Var As Variable
Dim WithEvents R4_Etat_prehenseur_Var As Variable
Dim plateau_R4 As Double
'R5
Dim WithEvents PCVUE_Etat_R5_Var As Variable
Dim WithEvents Etat_R5_Var As Variable
Dim WithEvents Cmd_R5_Var As Variable
Dim WithEvents R5_Etat_prehenseur_Var As Variable


'Plateaux
Dim WithEvents EmplRef_1_2_Var As Variable
Dim WithEvents EmplRef_3_4_Var As Variable
Dim WithEvents EmplRef_5_6_Var As Variable
Dim WithEvents EmplRef_7_8_Var As Variable
Dim WithEvents EmplRef_9_10_Var As Variable
Dim WithEvents EmplRef_11_12_Var As Variable
Dim WithEvents EmplRef_13_14_Var As Variable
Dim WithEvents EmplRef_15_16_Var As Variable
Dim WithEvents EmplRef_17_18_Var As Variable
Dim WithEvents EmplRef_19_20_Var As Variable
Dim WithEvents EmplRef_21_22_Var As Variable
Dim WithEvents EmplRef_23_24_Var As Variable
Dim WithEvents EmplRef_25_26_Var As Variable
Dim WithEvents EmplRef_27_28_Var As Variable
Dim WithEvents EmplRef_29_30_Var As Variable
Dim WithEvents EmplRef_31_32_Var As Variable
Dim WithEvents EmplRef_33_34_Var As Variable
Dim WithEvents EmplRef_35_36_Var As Variable
Dim WithEvents EmplRef_37_38_Var As Variable
Dim WithEvents EmplRef_39_40_Var As Variable
Dim WithEvents EmplRef_41_42_Var As Variable
Dim WithEvents EmplRef_43_44_Var As Variable
Dim WithEvents EmplRef_45_46_Var As Variable
Dim WithEvents EmplRef_47_48_Var As Variable
Dim WithEvents EmplRef_49_50_Var As Variable
Dim WithEvents EmplRef_51_52_Var As Variable
Dim WithEvents EmplRef_53_54_Var As Variable
Dim WithEvents EmplRef_55_56_Var As Variable
Dim WithEvents EmplRef_57_58_Var As Variable
Dim WithEvents EmplRef_59_60_Var As Variable
Dim WithEvents EmplRef_61_62_Var As Variable
Dim WithEvents EmplRef_63_64_Var As Variable
Dim WithEvents EmplRef_65_66_Var As Variable
Dim WithEvents EmplRef_67_68_Var As Variable
Dim WithEvents EmplRef_69_70_Var As Variable
Dim WithEvents EmplRef_71_72_Var As Variable
Dim WithEvents EmplRef_73_74_Var As Variable
Dim WithEvents EmplRef_75_76_Var As Variable
Dim WithEvents EmplRef_77_78_Var As Variable
Dim WithEvents EmplRef_79_80_Var As Variable
Dim WithEvents EmplRef_81_82_Var As Variable
Dim WithEvents EmplRef_83_84_Var As Variable
Dim WithEvents EmplRef_85_86_Var As Variable
Dim WithEvents EmplRef_87_88_Var As Variable
Dim WithEvents EmplRef_89_90_Var As Variable
Dim WithEvents EmplRef_91_92_Var As Variable
Dim WithEvents EmplRef_93_94_Var As Variable
Dim WithEvents EmplRef_95_96_Var As Variable
Dim WithEvents EmplRef_97_98_Var As Variable
Dim WithEvents EmplRef_99_100_Var As Variable
Dim WithEvents EmplRef_101_102_Var As Variable
Dim WithEvents EmplRef_103_104_Var As Variable
Dim WithEvents EmplRef_105_106_Var As Variable
Dim WithEvents EmplRef_107_108_Var As Variable
Dim WithEvents EmplRef_109_110_Var As Variable
'Dim WithEvents EmplRef_111_112_Var As Variable
'Dim WithEvents EmplRef_113_114_Var As Variable
'Dim WithEvents EmplRef_115_116_Var As Variable
'Dim WithEvents EmplRef_117_118_Var As Variable
'Dim WithEvents EmplRef_119_120_Var As Variable

'Four
Dim WithEvents PP_four_Var As Variable
Dim WithEvents PT_four_Var As Variable
Dim WithEvents etat_global_four_Var As Variable
Dim WithEvents info_four_Var As Variable

'Four de pre-sechage
Dim WithEvents capteur_FPS_Var As Variable
'Dim WithEvents cmd_FPS_var As Variable

'erreur
Dim WithEvents msg_erreur_1_16_Var As Variable
Dim WithEvents msg_erreur_17_32_Var As Variable
Dim WithEvents msg_erreur_33_48_Var As Variable
Dim WithEvents msg_erreur_49_64_Var As Variable

'secu
Dim WithEvents secu1_Var As Variable
Dim WithEvents secu2_Var As Variable
Dim WithEvents secu3_Var As Variable
Dim WithEvents secu4_Var As Variable
Dim WithEvents secu5_Var As Variable
Dim WithEvents secu14_Var As Variable



Private Function fvProject_BeforeQuit() As Boolean

        'For mode = 1 To 4
        
        '    For i = 0 To 23
        '        Variables("PIERCAN.CUVES.CUVE1.IBC.PLANNING.mode" & mode & ".H" & i) = 0
        '        Variables("PIERCAN.CUVES.CUVE3.IBC.PLANNING.mode" & mode & ".H" & i) = 0
        '        Variables("PIERCAN.CUVES.CUVE4.IBC.PLANNING.mode" & mode & ".H" & i) = 0
        '    Next i
        'Next mode

    'Call create_ibc_planning_file
    
End Function

Public Sub fvProject_StartupComplete()
    On Error GoTo ErrHandler
    
    Dim result As Variant
    Dim affaires_en_cours() As T_AFFAIRE
    Dim affaires_a_suivre() As T_AFFAIRE
    Dim num As Integer
    
    'connexion a la base de donnee
    Module_Database.Connect
    
    'init planning ibc
    'Call read_ibc_planning_file
    
    'init color
    Call TabColor
    
    'init variable
    [PIERCAN.AFFAIRE.archived] = False
    [PIERCAN.plateau_sans_of] = 0
    [PIERCAN.PLATEAU.nb_ligne_tab_prep] = 1
    ReDim current_users(2)
    
    ' activer trace
    trac_ok_var = True
    
    'init user
    If [PIERCAN.code_operateur_1] <> "" Then
        current_users(0) = Get_UTILISATEUR(Trim([PIERCAN.code_operateur_1]))
    Else
        current_users(0).auteur = ""
    End If
    
    If [PIERCAN.code_operateur_2] <> "" Then
        current_users(1) = Get_UTILISATEUR(Trim([PIERCAN.code_operateur_2]))
    Else
        current_users(1).auteur = ""
    End If
    
    If [PIERCAN.code_operateur_3] <> "" Then
        current_users(2) = Get_UTILISATEUR(Trim([PIERCAN.code_operateur_3]))
    Else
        current_users(2).auteur = ""
    End If
    
    'set variable cycle robot
    code_cycle_anterieur_R1 = 0
    code_cycle_anterieur_R2 = 0
    code_cycle_anterieur_R3 = 0
    code_cycle_anterieur_R4 = 0
    code_cycle_anterieur_R5 = 0
    
    'doevents
    
    'For index_cuve = 1 To 5
    '    Variables ("PIERCAN.CUVES.CUVE " & index_cuve & ".MAX_AUTORISATION_TREMPE")
    '    Variables ("PIERCAN.CUVES.CUVE " & index_cuve & ".MAX_REMPLISSAGE")
    '    Variables ("PIERCAN.CUVES.CUVE " & index_cuve & ".MIN_AUTORISATION_TREMPE")
    '    Variables ("PIERCAN.CUVES.CUVE " & index_cuve & ".MIN_REMPLISSAGE")
    'Next index_cuve
    
    'Init var Etat Robot ========================================
    
    'R1 =========================================================
    Variables.Add "PIERCAN.ROBOTS.R1.Etat_Job_Courant", fvVariableTypeRegister ' variable pcvue pour bouger les robots sur l'ihm
    Set PCVUE_Etat_R1_Var = [PIERCAN.ROBOTS.R1.Etat_Job_Courant]
    PCVUE_Etat_R1_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4000", fvVariableTypeRegister
    Set Etat_R1_Var = [PIERCAN.PLC.MW4000.MW4000]
    Etat_R1_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4010", fvVariableTypeRegister
    Set R1_Etat_prehenseur_Var = [PIERCAN.PLC.MW4000.MW4010]
    R1_Etat_prehenseur_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4500.MW4500", fvVariableTypeRegister
    Set Cmd_R1_Var = [PIERCAN.PLC.MW4500.MW4500]
    Cmd_R1_Var.EnableEvents = True
    
    'R2 =========================================================
    Variables.Add "PIERCAN.ROBOTS.R2.Etat_Job_Courant", fvVariableTypeRegister
    Set PCVUE_Etat_R2_Var = [PIERCAN.ROBOTS.R2.Etat_Job_Courant]
    PCVUE_Etat_R2_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4002", fvVariableTypeRegister
    Set Etat_R2_Var = [PIERCAN.PLC.MW4000.MW4002]
    Etat_R2_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4012", fvVariableTypeRegister
    Set R2_Etat_prehenseur_Var = [PIERCAN.PLC.MW4000.MW4012]
    R2_Etat_prehenseur_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4500.MW4502", fvVariableTypeRegister
    Set Cmd_R2_Var = [PIERCAN.PLC.MW4500.MW4502]
    Cmd_R2_Var.EnableEvents = True
    
    'R3 =========================================================
    Variables.Add "PIERCAN.ROBOTS.R3.Etat_Job_Courant", fvVariableTypeRegister
    Set PCVUE_Etat_R3_Var = [PIERCAN.ROBOTS.R3.Etat_Job_Courant]
    PCVUE_Etat_R3_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4004", fvVariableTypeRegister
    Set Etat_R3_Var = [PIERCAN.PLC.MW4000.MW4004]
    Etat_R3_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4014", fvVariableTypeRegister
    Set R3_Etat_prehenseur_Var = [PIERCAN.PLC.MW4000.MW4014]
    R3_Etat_prehenseur_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4500.MW4504", fvVariableTypeRegister
    Set Cmd_R3_Var = [PIERCAN.PLC.MW4500.MW4504]
    Cmd_R3_Var.EnableEvents = True
    
    'R4 =========================================================
    Variables.Add "PIERCAN.ROBOTS.R4.Etat_Job_Courant", fvVariableTypeRegister
    Set PCVUE_Etat_R4_Var = [PIERCAN.ROBOTS.R4.Etat_Job_Courant]
    PCVUE_Etat_R4_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4006", fvVariableTypeRegister
    Set Etat_R4_Var = [PIERCAN.PLC.MW4000.MW4006]
    Etat_R4_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4016", fvVariableTypeRegister
    Set R4_Etat_prehenseur_Var = [PIERCAN.PLC.MW4000.MW4016]
    R4_Etat_prehenseur_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4500.MW4506", fvVariableTypeRegister
    Set Cmd_R4_Var = [PIERCAN.PLC.MW4500.MW4506]
    Cmd_R4_Var.EnableEvents = True
    
    'R5 =========================================================
    Variables.Add "PIERCAN.ROBOTS.R5.Etat_Job_Courant", fvVariableTypeRegister
    Set PCVUE_Etat_R5_Var = [PIERCAN.ROBOTS.R5.Etat_Job_Courant]
    PCVUE_Etat_R5_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4008", fvVariableTypeRegister
    Set Etat_R5_Var = [PIERCAN.PLC.MW4000.MW4008]
    Etat_R5_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4000.MW4018", fvVariableTypeRegister
    Set R5_Etat_prehenseur_Var = [PIERCAN.PLC.MW4000.MW4018]
    R5_Etat_prehenseur_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW4500.MW4508", fvVariableTypeRegister
    Set Cmd_R5_Var = [PIERCAN.PLC.MW4500.MW4508]
    Cmd_R5_Var.EnableEvents = True
    
    
    'Init Variable PLC ==============================================
    
    '1 inhibition_plateau_1_16
    Variables.Add "PIERCAN.PLC.MW2000.MW2000", fvVariableTypeRegister
    Set inhibition_plateau_1_16_Var = [PIERCAN.PLC.MW2000.MW2000]
    inhibition_plateau_1_16_Var.EnableEvents = True
    '2 inhibition_plateau_17_32
    Variables.Add "PIERCAN.PLC.MW2000.MW2002", fvVariableTypeRegister
    Set inhibition_plateau_17_32_Var = [PIERCAN.PLC.MW2000.MW2002]
    inhibition_plateau_17_32_Var.EnableEvents = True
    
    '190 changer_plateau_1_16
    Variables.Add "PIERCAN.PLC.MW2000.MW2042", fvVariableTypeRegister
    Set changer_plateau_1_16_Var = [PIERCAN.PLC.MW2000.MW2042]
    changer_plateau_1_16_Var.EnableEvents = True
    '192 changer_plateau_17_32
    Variables.Add "PIERCAN.PLC.MW2000.MW2044", fvVariableTypeRegister
    Set changer_plateau_17_32_Var = [PIERCAN.PLC.MW2000.MW2044]
    changer_plateau_17_32_Var.EnableEvents = True
    
    
    '3 Cmde Couv Cuve
    Variables.Add "PIERCAN.PLC.MW2000.MW2004", fvVariableTypeRegister
    Set Cmde_Couv_Cuve_Var = [PIERCAN.PLC.MW2000.MW2004]
    Cmde_Couv_Cuve_Var.EnableEvents = True
    '4 Cmde Agit Cuve
    Variables.Add "PIERCAN.PLC.MW2000.MW2006", fvVariableTypeRegister
    Set Cmde_Agit_Cuve_Var = [PIERCAN.PLC.MW2000.MW2006]
    Cmde_Agit_Cuve_Var.EnableEvents = True

    '5 Etat Couvercle Cuves
    Variables.Add "PIERCAN.PLC.MW2500.MW2500", fvVariableTypeRegister
    Set Etat_Couv_Cuve_Var = [PIERCAN.PLC.MW2500.MW2500]
    Etat_Couv_Cuve_Var.EnableEvents = True
    '6 Etat Agitation Cuves
    Variables.Add "PIERCAN.PLC.MW2500.MW2502", fvVariableTypeRegister
    Set Etat_Agit_Cuve_Var = [PIERCAN.PLC.MW2500.MW2502]
    Etat_Agit_Cuve_Var.EnableEvents = True
    '7 Etat IBC Cuves
    Variables.Add "PIERCAN.PLC.MW2500.MW2504", fvVariableTypeRegister
    Set Etat_IBC_Cuve_Var = [PIERCAN.PLC.MW2500.MW2504]
    Etat_IBC_Cuve_Var.EnableEvents = True
    
    '8 Cmde Agit IBC
    Variables.Add "PIERCAN.PLC.MW2000.MW2008", fvVariableTypeRegister
    Set Cmde_Agit_IBC_Var = [PIERCAN.PLC.MW2000.MW2008]
    Cmde_Agit_IBC_Var.EnableEvents = True
    
    'Presence cuve
    'Variables.Add "PIERCAN.PLC.MW2000.MW2066", fvVariableTypeRegister
    'Set Presence_Cuve_Var = [PIERCAN.PLC.MW2000.MW2066]
    'Presence_Cuve_Var.EnableEvents = True
    
    
    'Plateaux =======================================================
    '39 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2544", fvVariableTypeRegister
    Set EmplRef_1_2_Var = [PIERCAN.PLC.MW2500.MW2544]
    EmplRef_1_2_Var.EnableEvents = True
    
    '40 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2546", fvVariableTypeRegister
    Set EmplRef_3_4_Var = [PIERCAN.PLC.MW2500.MW2546]
    EmplRef_3_4_Var.EnableEvents = True
    
    '41 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2548", fvVariableTypeRegister
    Set EmplRef_5_6_Var = [PIERCAN.PLC.MW2500.MW2548]
    EmplRef_5_6_Var.EnableEvents = True
    
    '42 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2550", fvVariableTypeRegister
    Set EmplRef_7_8_Var = [PIERCAN.PLC.MW2500.MW2550]
    EmplRef_7_8_Var.EnableEvents = True
    
    '43 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2552", fvVariableTypeRegister
    Set EmplRef_9_10_Var = [PIERCAN.PLC.MW2500.MW2552]
    EmplRef_9_10_Var.EnableEvents = True
    
    '44 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2554", fvVariableTypeRegister
    Set EmplRef_11_12_Var = [PIERCAN.PLC.MW2500.MW2554]
    EmplRef_11_12_Var.EnableEvents = True
    
    '45 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2556", fvVariableTypeRegister
    Set EmplRef_13_14_Var = [PIERCAN.PLC.MW2500.MW2556]
    EmplRef_13_14_Var.EnableEvents = True
    
    '46 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2558", fvVariableTypeRegister
    Set EmplRef_15_16_Var = [PIERCAN.PLC.MW2500.MW2558]
    EmplRef_15_16_Var.EnableEvents = True
    
    '47 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2560", fvVariableTypeRegister
    Set EmplRef_17_18_Var = [PIERCAN.PLC.MW2500.MW2560]
    EmplRef_17_18_Var.EnableEvents = True
    
    '48 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2562", fvVariableTypeRegister
    Set EmplRef_19_20_Var = [PIERCAN.PLC.MW2500.MW2562]
    EmplRef_19_20_Var.EnableEvents = True
    
    '49 Plateaux (RESERVE)
    Variables.Add "PIERCAN.PLC.MW2500.MW2564", fvVariableTypeRegister
    Set EmplRef_21_22_Var = [PIERCAN.PLC.MW2500.MW2564]
    EmplRef_21_22_Var.EnableEvents = True
    
    '50 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2566", fvVariableTypeRegister
    Set EmplRef_23_24_Var = [PIERCAN.PLC.MW2500.MW2566]
    EmplRef_23_24_Var.EnableEvents = True
    
    '51 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2568", fvVariableTypeRegister
    Set EmplRef_25_26_Var = [PIERCAN.PLC.MW2500.MW2568]
    EmplRef_25_26_Var.EnableEvents = True
    
    '52 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2570", fvVariableTypeRegister
    Set EmplRef_27_28_Var = [PIERCAN.PLC.MW2500.MW2570]
    EmplRef_27_28_Var.EnableEvents = True
    
    '53 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2572", fvVariableTypeRegister
    Set EmplRef_29_30_Var = [PIERCAN.PLC.MW2500.MW2572]
    EmplRef_29_30_Var.EnableEvents = True
    
    '54 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2574", fvVariableTypeRegister
    Set EmplRef_31_32_Var = [PIERCAN.PLC.MW2500.MW2574]
    EmplRef_31_32_Var.EnableEvents = True
    
    '55 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2576", fvVariableTypeRegister
    Set EmplRef_33_34_Var = [PIERCAN.PLC.MW2500.MW2576]
    EmplRef_33_34_Var.EnableEvents = True
    
    '56 Plateaux (RESERVE)
    Variables.Add "PIERCAN.PLC.MW2500.MW2578", fvVariableTypeRegister
    Set EmplRef_35_36_Var = [PIERCAN.PLC.MW2500.MW2578]
    EmplRef_35_36_Var.EnableEvents = True
    
    '57 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2580", fvVariableTypeRegister
    Set EmplRef_37_38_Var = [PIERCAN.PLC.MW2500.MW2580]
    EmplRef_37_38_Var.EnableEvents = True
    
    '58 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2582", fvVariableTypeRegister
    Set EmplRef_39_40_Var = [PIERCAN.PLC.MW2500.MW2582]
    EmplRef_39_40_Var.EnableEvents = True
    
    '59 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2584", fvVariableTypeRegister
    Set EmplRef_41_42_Var = [PIERCAN.PLC.MW2500.MW2584]
    EmplRef_41_42_Var.EnableEvents = True
    
    '60 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2586", fvVariableTypeRegister
    Set EmplRef_43_44_Var = [PIERCAN.PLC.MW2500.MW2586]
    EmplRef_43_44_Var.EnableEvents = True
    
    '61 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2588", fvVariableTypeRegister
    Set EmplRef_45_46_Var = [PIERCAN.PLC.MW2500.MW2588]
    EmplRef_45_46_Var.EnableEvents = True
    
    '62 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2590", fvVariableTypeRegister
    Set EmplRef_47_48_Var = [PIERCAN.PLC.MW2500.MW2590]
    EmplRef_47_48_Var.EnableEvents = True
    
    '63 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2592", fvVariableTypeRegister
    Set EmplRef_49_50_Var = [PIERCAN.PLC.MW2500.MW2592]
    EmplRef_49_50_Var.EnableEvents = True
    
    '64 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2594", fvVariableTypeRegister
    Set EmplRef_51_52_Var = [PIERCAN.PLC.MW2500.MW2594]
    EmplRef_51_52_Var.EnableEvents = True
    
    '65 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2596", fvVariableTypeRegister
    Set EmplRef_53_54_Var = [PIERCAN.PLC.MW2500.MW2596]
    EmplRef_53_54_Var.EnableEvents = True
    
    '66 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2598", fvVariableTypeRegister
    Set EmplRef_55_56_Var = [PIERCAN.PLC.MW2500.MW2598]
    EmplRef_55_56_Var.EnableEvents = True
    
    '67 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2600", fvVariableTypeRegister
    Set EmplRef_57_58_Var = [PIERCAN.PLC.MW2500.MW2600]
    EmplRef_57_58_Var.EnableEvents = True
    
    '68 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2602", fvVariableTypeRegister
    Set EmplRef_59_60_Var = [PIERCAN.PLC.MW2500.MW2602]
    EmplRef_59_60_Var.EnableEvents = True
    
    '69 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2604", fvVariableTypeRegister
    Set EmplRef_61_62_Var = [PIERCAN.PLC.MW2500.MW2604]
    EmplRef_61_62_Var.EnableEvents = True
    
    '70 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2606", fvVariableTypeRegister
    Set EmplRef_63_64_Var = [PIERCAN.PLC.MW2500.MW2606]
    EmplRef_63_64_Var.EnableEvents = True
    
    '71 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2608", fvVariableTypeRegister
    Set EmplRef_65_66_Var = [PIERCAN.PLC.MW2500.MW2608]
    EmplRef_65_66_Var.EnableEvents = True
    
    '72 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2610", fvVariableTypeRegister
    Set EmplRef_67_68_Var = [PIERCAN.PLC.MW2500.MW2610]
    EmplRef_67_68_Var.EnableEvents = True
    
    '73 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2612", fvVariableTypeRegister
    Set EmplRef_69_70_Var = [PIERCAN.PLC.MW2500.MW2612]
    EmplRef_69_70_Var.EnableEvents = True
    
    '74 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2614", fvVariableTypeRegister
    Set EmplRef_71_72_Var = [PIERCAN.PLC.MW2500.MW2614]
    EmplRef_71_72_Var.EnableEvents = True
    
    '75 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2616", fvVariableTypeRegister
    Set EmplRef_73_74_Var = [PIERCAN.PLC.MW2500.MW2616]
    EmplRef_73_74_Var.EnableEvents = True
    
    '76 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2618", fvVariableTypeRegister
    Set EmplRef_75_76_Var = [PIERCAN.PLC.MW2500.MW2618]
    EmplRef_75_76_Var.EnableEvents = True
    
    '77 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2620", fvVariableTypeRegister
    Set EmplRef_77_78_Var = [PIERCAN.PLC.MW2500.MW2620]
    EmplRef_77_78_Var.EnableEvents = True
    
    '78 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2622", fvVariableTypeRegister
    Set EmplRef_79_80_Var = [PIERCAN.PLC.MW2500.MW2622]
    EmplRef_79_80_Var.EnableEvents = True
    
    '79 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2624", fvVariableTypeRegister
    Set EmplRef_81_82_Var = [PIERCAN.PLC.MW2500.MW2624]
    EmplRef_81_82_Var.EnableEvents = True
    
    '80 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2626", fvVariableTypeRegister
    Set EmplRef_83_84_Var = [PIERCAN.PLC.MW2500.MW2626]
    EmplRef_83_84_Var.EnableEvents = True
    
    '81 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2628", fvVariableTypeRegister
    Set EmplRef_85_86_Var = [PIERCAN.PLC.MW2500.MW2628]
    EmplRef_85_86_Var.EnableEvents = True
    
    '82 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2630", fvVariableTypeRegister
    Set EmplRef_87_88_Var = [PIERCAN.PLC.MW2500.MW2630]
    EmplRef_87_88_Var.EnableEvents = True
    
    '83 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2632", fvVariableTypeRegister
    Set EmplRef_89_90_Var = [PIERCAN.PLC.MW2500.MW2632]
    EmplRef_89_90_Var.EnableEvents = True
    
    '84 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2634", fvVariableTypeRegister
    Set EmplRef_91_92_Var = [PIERCAN.PLC.MW2500.MW2634]
    EmplRef_91_92_Var.EnableEvents = True
    
    '85 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2636", fvVariableTypeRegister
    Set EmplRef_93_94_Var = [PIERCAN.PLC.MW2500.MW2636]
    EmplRef_93_94_Var.EnableEvents = True
    
    '86 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2638", fvVariableTypeRegister
    Set EmplRef_95_96_Var = [PIERCAN.PLC.MW2500.MW2638]
    EmplRef_95_96_Var.EnableEvents = True
    
    '87 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2640", fvVariableTypeRegister
    Set EmplRef_97_98_Var = [PIERCAN.PLC.MW2500.MW2640]
    EmplRef_97_98_Var.EnableEvents = True
    
    '88 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2642", fvVariableTypeRegister
    Set EmplRef_99_100_Var = [PIERCAN.PLC.MW2500.MW2642]
    EmplRef_99_100_Var.EnableEvents = True
    
    '89 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2644", fvVariableTypeRegister
    Set EmplRef_101_102_Var = [PIERCAN.PLC.MW2500.MW2644]
    EmplRef_101_102_Var.EnableEvents = True
    
    '90 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2646", fvVariableTypeRegister
    Set EmplRef_103_104_Var = [PIERCAN.PLC.MW2500.MW2646]
    EmplRef_103_104_Var.EnableEvents = True
    
    '91 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2648", fvVariableTypeRegister
    Set EmplRef_105_106_Var = [PIERCAN.PLC.MW2500.MW2648]
    EmplRef_105_106_Var.EnableEvents = True
    
    '92 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2650", fvVariableTypeRegister
    Set EmplRef_107_108_Var = [PIERCAN.PLC.MW2500.MW2650]
    EmplRef_107_108_Var.EnableEvents = True
    
    '93 Plateaux
    Variables.Add "PIERCAN.PLC.MW2500.MW2652", fvVariableTypeRegister
    Set EmplRef_109_110_Var = [PIERCAN.PLC.MW2500.MW2652]
    EmplRef_109_110_Var.EnableEvents = True
    
    '151 plateau_fini_1_16
    Variables.Add "PIERCAN.PLC.MW2500.MW2680", fvVariableTypeRegister
    Set plateau_fini_1_16_Var = [PIERCAN.PLC.MW2500.MW2680]
    plateau_fini_1_16_Var.EnableEvents = True
    '152 plateau_fini_16_32
    Variables.Add "PIERCAN.PLC.MW2500.MW2682", fvVariableTypeRegister
    Set plateau_fini_17_32_Var = [PIERCAN.PLC.MW2500.MW2682]
    plateau_fini_17_32_Var.EnableEvents = True
    
    '155 API_Pcvue_echange_1
    Variables.Add "PIERCAN.PLC.MW2500.MW2664", fvVariableTypeRegister
    Set API_Pcvue_echange_1_Var = [PIERCAN.PLC.MW2500.MW2664]
    API_Pcvue_echange_1_Var.EnableEvents = True
    
    '157 Four
    Variables.Add "PIERCAN.PLC.MW5000.MW5000", fvVariableTypeRegister
    Set PP_four_Var = [PIERCAN.PLC.MW5000.MW5000]
    PP_four_Var.EnableEvents = True
    
    '158 Four
    Variables.Add "PIERCAN.PLC.MW5000.MW5002", fvVariableTypeRegister
    Set PT_four_Var = [PIERCAN.PLC.MW5000.MW5002]
    PT_four_Var.EnableEvents = True
    
    '159 Four
    Variables.Add "PIERCAN.PLC.MW2500.MW2694", fvVariableTypeRegister
    Set etat_global_four_Var = [PIERCAN.PLC.MW2500.MW2694]
    etat_global_four_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW5000.MW5004", fvVariableTypeRegister
    Set info_four_Var = [PIERCAN.PLC.MW5000.MW5004]
    info_four_Var.EnableEvents = True
    
    'Four de pre-sechage
    Variables.Add "PIERCAN.PLC.MW2500.MW2666", fvVariableTypeRegister
    Set capteur_FPS_Var = [PIERCAN.PLC.MW2500.MW2666]
    capteur_FPS_Var.EnableEvents = True
    
    
    '================================================================
    'erreur
    '================================================================
    Variables.Add "PIERCAN.PLC.MW2500.MW2686", fvVariableTypeRegister
    Set msg_erreur_1_16_Var = [PIERCAN.PLC.MW2500.MW2686]
    msg_erreur_1_16_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW2500.MW2688", fvVariableTypeRegister
    Set msg_erreur_17_32_Var = [PIERCAN.PLC.MW2500.MW2688]
    msg_erreur_17_32_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW2500.MW2690", fvVariableTypeRegister
    Set msg_erreur_33_48_Var = [PIERCAN.PLC.MW2500.MW2690]
    msg_erreur_33_48_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW2500.MW2692", fvVariableTypeRegister
    Set msg_erreur_49_64_Var = [PIERCAN.PLC.MW2500.MW2692]
    msg_erreur_49_64_Var.EnableEvents = True
    
    '================================================================
    'secu
    '================================================================
    Variables.Add "PIERCAN.PLC.MW10100.MW10170", fvVariableTypeRegister
    Set secu1_Var = [PIERCAN.PLC.MW10100.MW10170]
    secu1_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW10100.MW10172", fvVariableTypeRegister
    Set secu2_Var = [PIERCAN.PLC.MW10100.MW10172]
    secu2_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW10100.MW10173", fvVariableTypeRegister
    Set secu3_Var = [PIERCAN.PLC.MW10100.MW10173]
    secu3_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW10100.MW10174", fvVariableTypeRegister
    Set secu4_Var = [PIERCAN.PLC.MW10100.MW10174]
    secu4_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW10100.MW10175", fvVariableTypeRegister
    Set secu5_Var = [PIERCAN.PLC.MW10100.MW10175]
    secu5_Var.EnableEvents = True
    
    Variables.Add "PIERCAN.PLC.MW10100.MW10184", fvVariableTypeRegister
    Set secu14_Var = [PIERCAN.PLC.MW10100.MW10184]
    secu14_Var.EnableEvents = True
    
    '=========================== init listes PLATEAU ===============================
    ReDim list_plateaux_en_cours(28)
    ReDim list_plateaux_a_suivre(28)
    
    '[PIERCAN.PLATEAU.nb_plateau_a_suivre] = 0
    nb_plateau_a_suivre = 29
    nb_plateau_prep = 1
     
    affaires_en_cours = Get_OF_EN_COURS()
    
    affaires_a_suivre = Get_OF_A_SUIVRE()
    'indice_plateau = 1
    
    'ReDim affaires_en_cours(-1 to -1)
    
    'affaire en cours
    If UBound(affaires_en_cours) + 1 > 0 Then
        For index_aff = 0 To UBound(affaires_en_cours)
            For index_of = 0 To UBound(affaires_en_cours(index_aff).ofs)
                'info PLATEAU
                indice_tab = affaires_en_cours(index_aff).ofs(index_of).plateau
                If affaires_en_cours(index_aff).ofs(index_of).of_id <> "" Then
                    list_plateaux_en_cours(indice_tab).affaire = affaires_en_cours(index_aff).affaire_id
                    list_plateaux_en_cours(indice_tab).of = affaires_en_cours(index_aff).ofs(index_of).of_id
                    list_plateaux_en_cours(indice_tab).code_art = affaires_en_cours(index_aff).ofs(index_of).article.cod_crt_trp 'inversion de code_article par cod_crt_trp
                    list_plateaux_en_cours(indice_tab).num_plateau = affaires_en_cours(index_aff).ofs(index_of).plateau
                    list_plateaux_en_cours(indice_tab).version_cdt = affaires_en_cours(index_aff).ofs(index_of).article.version_active
                    list_plateaux_en_cours(indice_tab).libelle = affaires_en_cours(index_aff).ofs(index_of).article.libelle
                    list_plateaux_en_cours(indice_tab).annule = False
                    'info cdt
                    
                    'design PLATEAU
                    list_plateaux_en_cours(indice_tab).num_p1 = list_plateaux_en_cours(indice_tab).num_plateau * 10 + 1
                    list_plateaux_en_cours(indice_tab).num_p2 = list_plateaux_en_cours(indice_tab).num_plateau * 10 + 2
                    'indice_plateau = indice_plateau + 1
                    
                    'TODO : code cdt
                    list_plateaux_en_cours(indice_tab).code_cdt = affaires_en_cours(index_aff).ofs(index_of).article.code_article 'inversion de cod_crt_trp par code_article
                    
                    'info carte de trempe
                    info_cdt_of_en_cours = Get_ARTICLE(affaires_en_cours(index_aff).ofs(index_of).article.code_article, affaires_en_cours(index_aff).ofs(index_of).article.version_active)
                        
                    list_plateaux_en_cours(indice_tab).temps_Four_pre_sech = info_cdt_of_en_cours.temps_FOUR_PRE
                    list_plateaux_en_cours(indice_tab).temps_PSCOAG = info_cdt_of_en_cours.temps_att_PSCOAG
                    list_plateaux_en_cours(indice_tab).temps_PSR2 = info_cdt_of_en_cours.temps_att_PSRINCAGE
                    list_plateaux_en_cours(indice_tab).temps_PST1 = info_cdt_of_en_cours.temps_att_PSLEACHING
                    
                    list_plateaux_en_cours(indice_tab).cycle_PPF = info_cdt_of_en_cours.cycle_PPF
                    list_plateaux_en_cours(indice_tab).cycle_PPNC = info_cdt_of_en_cours.cycle_PPNC
                    list_plateaux_en_cours(indice_tab).cycle_Talcage = info_cdt_of_en_cours.cycle_Talcage
                    
                    list_plateaux_en_cours(indice_tab).temps_trempe_cuve1 = info_cdt_of_en_cours.temps_trempe_cuve1
                    list_plateaux_en_cours(indice_tab).temps_trempe_cuve2 = info_cdt_of_en_cours.temps_trempe_cuve2
                    list_plateaux_en_cours(indice_tab).temps_trempe_cuve3 = info_cdt_of_en_cours.temps_trempe_cuve3
                    list_plateaux_en_cours(indice_tab).temps_trempe_cuve4 = info_cdt_of_en_cours.temps_trempe_cuve4
                    list_plateaux_en_cours(indice_tab).temps_trempe_cuve5 = info_cdt_of_en_cours.temps_trempe_cuve5
                    
                    For index_cuve = 0 To 4
                        list_plateaux_en_cours(indice_tab).presence_cuve(index_cuve) = info_cdt_of_en_cours.mat_cuve(index_cuve)
                    Next index_cuve
                    
                Else
                    list_plateaux_en_cours(indice_tab).annule = True
                    list_plateaux_en_cours(indice_tab).num_plateau = affaires_en_cours(index_aff).ofs(index_of).plateau
                    list_plateaux_en_cours(indice_tab).num_p1 = list_plateaux_en_cours(indice_tab).num_plateau * 10 + 1
                    list_plateaux_en_cours(indice_tab).num_p2 = list_plateaux_en_cours(indice_tab).num_plateau * 10 + 2
                End If
                
                'nb passage en trempe TODO a redefinir dans OUTILLAGE
                list_plateaux_en_cours(indice_tab).nb_passage_trempe = affaires_en_cours(index_aff).ofs(index_of).article.nb_passage_trempe
                list_plateaux_a_suivre(indice_tab).nb_passage_trempe = affaires_en_cours(index_aff).ofs(index_of).article.nb_passage_trempe
                
            Next index_of
        Next index_aff
        
        Debug.Print ("============ Inhibition plateau ==========")
        
        For num_plateau = 1 To 28
            Variables("PIERCAN.PLATEAU.inhibition.plateau" & num_plateau) = list_plateaux_en_cours(num_plateau).annule
        Next num_plateau
        
        Variables("PIERCAN.PLC.MW2000.MW2000") = (2 ^ 0) * IIf(list_plateaux_en_cours(1).annule = False, 0, 1) + (2 ^ 1) * IIf(list_plateaux_en_cours(2).annule = False, 0, 1) + _
                                                      (2 ^ 2) * IIf(list_plateaux_en_cours(3).annule = False, 0, 1) + _
                                                      (2 ^ 3) * IIf(list_plateaux_en_cours(4).annule = False, 0, 1) + _
                                                      (2 ^ 4) * IIf(list_plateaux_en_cours(5).annule = False, 0, 1) + _
                                                      (2 ^ 5) * IIf(list_plateaux_en_cours(6).annule = False, 0, 1) + _
                                                      (2 ^ 6) * IIf(list_plateaux_en_cours(7).annule = False, 0, 1) + _
                                                      (2 ^ 7) * IIf(list_plateaux_en_cours(8).annule = False, 0, 1) + _
                                                      (2 ^ 8) * IIf(list_plateaux_en_cours(9).annule = False, 0, 1) + (2 ^ 9) * IIf(list_plateaux_en_cours(10).annule = False, 0, 1) + (2 ^ 10) * IIf(list_plateaux_en_cours(11).annule = False, 0, 1) + (2 ^ 11) * IIf(list_plateaux_en_cours(12).annule = False, 0, 1) + (2 ^ 12) * IIf(list_plateaux_en_cours(13).annule = False, 0, 1) + (2 ^ 13) * IIf(list_plateaux_en_cours(14).annule = False, 0, 1) + (2 ^ 14) * IIf(list_plateaux_en_cours(15).annule = False, 0, 1) + (2 ^ 15) * IIf(list_plateaux_en_cours(16).annule = False, 0, 1)
                                                      
        Variables("PIERCAN.PLC.MW2000.MW2002") = (2 ^ 0) * IIf(list_plateaux_en_cours(17).annule = False, 0, 1) + (2 ^ 1) * IIf(list_plateaux_en_cours(18).annule = False, 0, 1) + _
                                                      (2 ^ 2) * IIf(list_plateaux_en_cours(19).annule = False, 0, 1) + _
                                                      (2 ^ 3) * IIf(list_plateaux_en_cours(20).annule = False, 0, 1) + _
                                                      (2 ^ 4) * IIf(list_plateaux_en_cours(21).annule = False, 0, 1) + _
                                                      (2 ^ 5) * IIf(list_plateaux_en_cours(22).annule = False, 0, 1) + _
                                                      (2 ^ 6) * IIf(list_plateaux_en_cours(23).annule = False, 0, 1) + _
                                                      (2 ^ 7) * IIf(list_plateaux_en_cours(24).annule = False, 0, 1) + _
                                                      (2 ^ 8) * IIf(list_plateaux_en_cours(25).annule = False, 0, 1) + (2 ^ 9) * IIf(list_plateaux_en_cours(26).annule = False, 0, 1) + (2 ^ 10) * IIf(list_plateaux_en_cours(27).annule = False, 0, 1) + (2 ^ 11) * IIf(list_plateaux_en_cours(28).annule = False, 0, 1)

        DoEvents
        'Debug.Print ("valeur registre 2000 : " & Variables("PIERCAN.PLC.MW2000.MW2000"))
        'Debug.Print ("valeur registre 2002 : " & Variables("PIERCAN.PLC.MW2000.MW2002"))
        
        DoEvents
        
        'changement de moule
        changer_plateau_1_16_Var_ValueChange
        changer_plateau_17_32_Var_ValueChange
        DoEvents
        
   Else
     ReDim list_plateaux_en_cours(28)
   End If
   
   'affaire a suivre
   If UBound(affaires_a_suivre) + 1 > 0 Then
        For index_aff = 0 To UBound(affaires_a_suivre)
            For index_of = 0 To UBound(affaires_a_suivre(index_aff).ofs)
                'info PLATEAU
                indice_tab = affaires_a_suivre(index_aff).ofs(index_of).plateau
                If affaires_a_suivre(index_aff).ofs(index_of).of_id <> "" Then
                    list_plateaux_a_suivre(indice_tab).affaire = affaires_a_suivre(index_aff).affaire_id
                    list_plateaux_a_suivre(indice_tab).of = affaires_a_suivre(index_aff).ofs(index_of).of_id
                    list_plateaux_a_suivre(indice_tab).code_art = affaires_a_suivre(index_aff).ofs(index_of).article.cod_crt_trp 'inversion de code_article par cod_crt_trp
                    list_plateaux_a_suivre(indice_tab).num_plateau = affaires_a_suivre(index_aff).ofs(index_of).plateau
                    list_plateaux_a_suivre(indice_tab).version_cdt = affaires_a_suivre(index_aff).ofs(index_of).article.version_active
                    list_plateaux_a_suivre(indice_tab).libelle = affaires_a_suivre(index_aff).ofs(index_of).article.libelle
                    'design PLATEAU
                    list_plateaux_a_suivre(indice_tab).num_p1 = list_plateaux_a_suivre(indice_tab).num_plateau * 10 + 1
                    list_plateaux_a_suivre(indice_tab).num_p2 = list_plateaux_a_suivre(indice_tab).num_plateau * 10 + 2
                    'indice_plateau = indice_plateau + 1
                    
                    'TODO : code cdt
                    list_plateaux_a_suivre(indice_tab).code_cdt = affaires_a_suivre(index_aff).ofs(index_of).article.code_article 'inversion de cod_crt_trp par code_article
                    
                    'info carte de trempe
                    info_cdt_of_a_suivre = Get_ARTICLE(affaires_a_suivre(index_aff).ofs(index_of).article.code_article, affaires_a_suivre(index_aff).ofs(index_of).article.version_active)
                        
                    list_plateaux_a_suivre(indice_tab).temps_Four_pre_sech = info_cdt_of_a_suivre.temps_FOUR_PRE
                    list_plateaux_a_suivre(indice_tab).temps_PSCOAG = info_cdt_of_a_suivre.temps_att_PSCOAG
                    list_plateaux_a_suivre(indice_tab).temps_PSR2 = info_cdt_of_a_suivre.temps_att_PSRINCAGE
                    list_plateaux_a_suivre(indice_tab).temps_PST1 = info_cdt_of_a_suivre.temps_att_PSLEACHING
                    
                    list_plateaux_a_suivre(indice_tab).cycle_PPF = info_cdt_of_a_suivre.cycle_PPF
                    list_plateaux_a_suivre(indice_tab).cycle_PPNC = info_cdt_of_a_suivre.cycle_PPNC
                    list_plateaux_a_suivre(indice_tab).cycle_Talcage = info_cdt_of_a_suivre.cycle_Talcage
                    
                    list_plateaux_a_suivre(indice_tab).temps_trempe_cuve1 = info_cdt_of_a_suivre.temps_trempe_cuve1
                    list_plateaux_a_suivre(indice_tab).temps_trempe_cuve2 = info_cdt_of_a_suivre.temps_trempe_cuve2
                    list_plateaux_a_suivre(indice_tab).temps_trempe_cuve3 = info_cdt_of_a_suivre.temps_trempe_cuve3
                    list_plateaux_a_suivre(indice_tab).temps_trempe_cuve4 = info_cdt_of_a_suivre.temps_trempe_cuve4
                    list_plateaux_a_suivre(indice_tab).temps_trempe_cuve5 = info_cdt_of_a_suivre.temps_trempe_cuve5
                    
                    For index_cuve = 0 To 4
                        list_plateaux_a_suivre(indice_tab).presence_cuve(index_cuve) = info_cdt_of_a_suivre.mat_cuve(index_cuve)
                    Next index_cuve
                    
                    
                    
                    
                Else
                    list_plateaux_a_suivre(indice_tab).annule = True
                    list_plateaux_a_suivre(indice_tab).num_plateau = affaires_a_suivre(index_aff).ofs(index_of).plateau
                    list_plateaux_a_suivre(indice_tab).num_p1 = list_plateaux_a_suivre(indice_tab).num_plateau * 10 + 1
                    list_plateaux_a_suivre(indice_tab).num_p2 = list_plateaux_a_suivre(indice_tab).num_plateau * 10 + 2
                End If
            Next index_of
        Next index_aff
        
   Else
     ReDim list_plateaux_a_suivre(28)
   End If
    
    'affaire en preparation
    list_plateaux_prepa = list_plateaux_a_suivre
    'nb_plateau_a_suivre = UBound(list_plateaux_a_suivre)
    'nb_plateau_prep = nb_plateau_a_suivre
    nb_plateau_prep = 29
    
    ' init tracking var PLATEAU =======================
    Set RT_plateau_fini = New Collection
    Dim index_plateau As Integer
    
    flag_plateau_fini = False
    
    For index_plateau = 1 To 28
        RT_AjouterVariable_plateau_fini "PIERCAN.PLATEAU.fini.plateau" & index_plateau, index_plateau
    Next index_plateau
    
    DoEvents
    
    '=========================== fin PLATEAU ====================================
    
    'flag_plateau_fini = False
    
    charger_four_indications
    
    '================================================================
    'SCADA : lancement de l'´equipement
    '================================================================
    [PIERCAN.projet_ok] = 1
    [PIERCAN.list_ok] = 1
    refresh
    Mimics.Open ("PRODUCTION")
    
    DoEvents
    
    Exit Sub
    
ErrHandler:
    Global_Module.ErrorManagement "fvProject_StartupComplete", "ThisProject", Err.Description
    
End Sub

Public Sub charger_four_indications()
    On Error GoTo ErrHandler
    Dim FileName As String
    Dim File1 As Integer
    Dim Index As String
    FileName = ThisProject.Path & "\TP\Four.txt"
    File1 = FreeFile
    Open FileName For Input As #File1
    For i = 1 To 4
        Line Input #File1, Index
        Variables("PIERCAN.FOUR.indication" & i) = Index
    Next i
    Close #File1
    Exit Sub
ErrHandler:
    Close #File1
    For i = 1 To 4
        Variables("PIERCAN.FOUR.indication" & i) = 0
    Next i
    File1 = FreeFile
    Open FileName For Output As #File1
    For i = 1 To 4
        Print #File1, 0
    Next i
    Close #File1
End Sub

Public Sub PCVUE_Etat_R1_Var_ValueChange()
    
    Select Case [PIERCAN.ROBOTS.R1.Etat_Job_Courant]
        
        '================================================
        'R1
        '================================================
        
            '================================================
            'Four
            '================================================
            'four A
            Case 1001, 1035, 1039:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 93.6
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R1.x_plateau] = 623
                [PIERCAN.ROBOTS.R1.y_plateau] = 214
          
            'four B
            Case 1002, 1036, 1040:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 68.4
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 20
                [PIERCAN.ROBOTS.R1.x_plateau] = 623
                [PIERCAN.ROBOTS.R1.y_plateau] = 260
          
            'four C
            Case 1003, 1037, 1041:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 43.2
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R1.x_plateau] = 623
                [PIERCAN.ROBOTS.R1.y_plateau] = 339
                    
            'four D
            Case 1004, 1038, 1042:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 32.4
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R1.x_plateau] = 623
                [PIERCAN.ROBOTS.R1.y_plateau] = 385
                    
            '================================================
            'Refroidissement
            '================================================
            '1005_REFROID_POSE_1A 1011_REFROID_PRISE_1A
            Case 1005, 1011:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 39.6
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 330
                [PIERCAN.ROBOTS.R1.x_plateau] = 416
                [PIERCAN.ROBOTS.R1.y_plateau] = 185
        
            '1006_REFROID_POSE_1B 1012_REFROID_PRISE_1B
            Case 1006, 1012:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 39.6
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 330
                [PIERCAN.ROBOTS.R1.x_plateau] = 416
                [PIERCAN.ROBOTS.R1.y_plateau] = 220
                
            '1007_REFROID_POSE_2A 1013_REFROID_PRISE_2A
            Case 1007, 1013:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 3.6
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 355
                [PIERCAN.ROBOTS.R1.x_plateau] = 483
                [PIERCAN.ROBOTS.R1.y_plateau] = 185
                    
            '1008_REFROID_POSE_2B 1014_REFROID_PRISE_2B
            Case 1008, 1014:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 3.6
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 355
                [PIERCAN.ROBOTS.R1.x_plateau] = 483
                [PIERCAN.ROBOTS.R1.y_plateau] = 220
                    
            '1009_REFROID_POSE_3A 1015_REFROID_PRISE_3A
            Case 1009, 1015:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 342
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 350
                [PIERCAN.ROBOTS.R1.x_plateau] = 548
                [PIERCAN.ROBOTS.R1.y_plateau] = 184
                
            '1010_REFROID_POSE_3B 1016_REFROID_PRISE_3B
            Case 1010, 1016:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 342
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 350
                [PIERCAN.ROBOTS.R1.x_plateau] = 548
                [PIERCAN.ROBOTS.R1.y_plateau] = 220
            
            '================================================
            'Demoulage
            '================================================
            Case 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1043:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 266.4
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 95
                [PIERCAN.ROBOTS.R1.x_plateau] = 428
                [PIERCAN.ROBOTS.R1.y_plateau] = 323
    
            '================================================
            'Sechage Rincage PSR1
            '================================================
            '1024_PSR1_POSE_A
            Case 1024, 1028:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 205.2
                [PIERCAN.ROBOTS.R1.x_plateau] = 414
                [PIERCAN.ROBOTS.R1.y_plateau] = 560
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 0
                
                '1025_PSR1_POSE_B
            Case 1025, 1029:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 205.2
                [PIERCAN.ROBOTS.R1.x_plateau] = 414
                [PIERCAN.ROBOTS.R1.y_plateau] = 531
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 0
            '================================================
            'Sechage Rincage2 PSR2
            '================================================
            Case 1026, 1030:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 122.4
                [PIERCAN.ROBOTS.R1.x_plateau] = 643
                [PIERCAN.ROBOTS.R1.y_plateau] = 497
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 0
                
            Case 1027, 1031:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 122.4
                [PIERCAN.ROBOTS.R1.x_plateau] = 587
                [PIERCAN.ROBOTS.R1.y_plateau] = 497
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 0
            
            '================================================
            'Caisse de Talcage
            '================================================
            Case 1032, 1033, 1034:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 216
                [PIERCAN.ROBOTS.R1.x_plateau] = 323
                [PIERCAN.ROBOTS.R1.y_plateau] = 445
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 40
                
            '================================================
            'Position neutre
            '================================================
            Case Else:
                [PIERCAN.ROBOTS.R1.BaseRotation] = 0
                [PIERCAN.ROBOTS.R1.x_plateau] = 195
                [PIERCAN.ROBOTS.R1.y_plateau] = 385
                [PIERCAN.ROBOTS.R1.ElbowRotation] = 0
                
            DoEvents
    End Select

End Sub

Public Sub PCVUE_Etat_R2_Var_ValueChange()

    plateau_R2 = [PIERCAN.PLC.MW2500.MW2554]
    DoEvents
    
    Select Case [PIERCAN.ROBOTS.R2.Etat_Job_Courant]
        
        '================================================
        'R2
        '================================================
        
        '================================================
        'PSR1
        '================================================
        '2001_PSR1_PRISE 2003_PSR1_POSE_pas_utilise
        Case 2001, 2003:
            [PIERCAN.ROBOTS.R2.BaseRotation] = 244.8
            [PIERCAN.ROBOTS.R2.ElbowRotation] = 266.4
            [PIERCAN.ROBOTS.R2.x_plateau] = 0
            [PIERCAN.ROBOTS.R2.y_plateau] = 0
             
        '================================================
        'PSR2
        '================================================
                
        '2002_PSR2_PRISE 2004_PSR2_POSE
        Case 2002, 2004:
            [PIERCAN.ROBOTS.R2.BaseRotation] = 316.8
            [PIERCAN.ROBOTS.R2.ElbowRotation] = 360
            [PIERCAN.ROBOTS.R2.x_plateau] = 0
            [PIERCAN.ROBOTS.R2.y_plateau] = 0
            
            
        '================================================
        'CUVE1
        '================================================
                
        '2005_CUVE1_TREMPE
        Case 2005:
            
            [PIERCAN.ROBOTS.R2.BaseRotation] = 151.2
            [PIERCAN.ROBOTS.R2.ElbowRotation] = 320.4
            [PIERCAN.ROBOTS.R2.x_plateau] = 0
            [PIERCAN.ROBOTS.R2.y_plateau] = 0
            
            trace_cuve (plateau_R2 And &HFFFF&), (plateau_R2 \ (2 ^ 16)), type_message.Debut_trempe, type_lieu.CUVE1 'debut trempe cuve 1
            
        '================================================
        'CUVE2
        '================================================
         
        '2006_CUVE2_TREMPE
        Case 2006:
            [PIERCAN.ROBOTS.R2.BaseRotation] = 36
            [PIERCAN.ROBOTS.R2.ElbowRotation] = 86.4
            [PIERCAN.ROBOTS.R2.x_plateau] = 0
            [PIERCAN.ROBOTS.R2.y_plateau] = 0
            
            trace_cuve (plateau_R2 And &HFFFF&), (plateau_R2 \ (2 ^ 16)), type_message.Debut_trempe, type_lieu.CUVE2 'debut trempe cuve 2
            'passage trempe
            If trac_ok_var = True Then
                Update_nb_passage_trempe ((plateau_R2 And &HFFFF&) \ 10), False
                list_plateaux_en_cours(((plateau_R2 And &HFFFF&) \ 10)).nb_passage_trempe = list_plateaux_en_cours(((plateau_R2 And &HFFFF&) \ 10)).nb_passage_trempe + 1
            End If
            
        '================================================
        'Posage coag
        '================================================
                
        '2007_PCOAG_POSE
        Case 2007:
            [PIERCAN.ROBOTS.R2.BaseRotation] = 349.2
            [PIERCAN.ROBOTS.R2.ElbowRotation] = 10.8
            [PIERCAN.ROBOTS.R2.x_plateau] = 0
            [PIERCAN.ROBOTS.R2.y_plateau] = 0

        '================================================
        'Autre
        '================================================
        
        '2008_RETOURNEMENT_BAS_HAUT 2009_CUVE1_PCOAG
        Case 2008, 2009:
            [PIERCAN.ROBOTS.R2.BaseRotation] = 320.4
            [PIERCAN.ROBOTS.R2.ElbowRotation] = 180
            [PIERCAN.ROBOTS.R2.x_plateau] = 0
            [PIERCAN.ROBOTS.R2.y_plateau] = 0
              
    End Select
    DoEvents
    'Debug.Print ("============= Debut job ROBOT 2 ==============")
    'Debug.Print ("Code robot :" & code_cycle_anterieur_R2 & " job courant :" & [PIERCAN.ROBOTS.R2.Etat_Job_Courant])
    DoEvents
    
    If (code_cycle_anterieur_R2 = 2005) And ([PIERCAN.ROBOTS.R2.Etat_Job_Courant] <> 2005) Then
        'trace fin cuve 1
        'Debug.Print ("trace trempe cuve 1")
        trace_cuve (plateau_R2 And &HFFFF&), (plateau_R2 \ (2 ^ 16)), type_message.Fin_trempe, type_lieu.CUVE1
        code_cycle_anterieur_R2 = 0
        passage_cuve_1 = True
    End If
    
    If (code_cycle_anterieur_R2 = 2006) And ([PIERCAN.ROBOTS.R2.Etat_Job_Courant] <> 2006) Then
        'trace fin cuve 2
        trace_cuve (plateau_R2 And &HFFFF&), (plateau_R2 \ (2 ^ 16)), type_message.Fin_trempe, type_lieu.CUVE2
        'If [PIERCAN.debut_trempe_cuve2] = True Then
            '[PIERCAN.debut_trempe_cuve2] = 0 'fin timer
            '[PIERCAN.cuves.CUVE2.temps_restant] = 0 'raz
        'End If
        code_cycle_anterieur_R2 = 0
        passage_cuve_2 = True
    End If
    
    If passage_cuve_1 <> True Or passage_cuve_2 <> True Then
        DoEvents
        code_cycle_anterieur_R2 = [PIERCAN.ROBOTS.R2.Etat_Job_Courant]
    Else
        passage_cuve_1 = False
        passage_cuve_2 = False
    End If
    'Debug.Print ("============= Fin job ROBOT 2 ==============")
    
End Sub

Public Sub PCVUE_Etat_R3_Var_ValueChange()
    
    plateau_R3 = [PIERCAN.PLC.MW2500.MW2556]
    DoEvents
    
    Select Case [PIERCAN.ROBOTS.R3.Etat_Job_Courant]
        
        '================================================
        'R3
        '================================================
        
            '================================================
            'PCOAG
            '================================================
            '3001_PCOAG_PRISE
            Case 3001:
                [PIERCAN.ROBOTS.R3.BaseRotation] = 180
                [PIERCAN.ROBOTS.R3.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R3.x_plateau] = 0
                [PIERCAN.ROBOTS.R3.y_plateau] = 0
                
            '================================================
            'CUVE3
            '================================================
                
            '3002_CUVE3_TREMPE
            Case 3002:
                [PIERCAN.ROBOTS.R3.BaseRotation] = 151.2
                [PIERCAN.ROBOTS.R3.ElbowRotation] = 259.2
                [PIERCAN.ROBOTS.R3.x_plateau] = 0
                [PIERCAN.ROBOTS.R3.y_plateau] = 0
                
                trace_cuve (plateau_R3 And &HFFFF&), (plateau_R3 \ (2 ^ 16)), type_message.Debut_trempe, type_lieu.CUVE3 'debut trempe cuve 3
            
            '================================================
            'CUVE4
            '================================================
         
            '3003_CUVE4_TREMPE
            Case 3003:
                [PIERCAN.ROBOTS.R3.BaseRotation] = 25.2
                [PIERCAN.ROBOTS.R3.ElbowRotation] = 115.2
                [PIERCAN.ROBOTS.R3.x_plateau] = 0
                [PIERCAN.ROBOTS.R3.y_plateau] = 0
                
                trace_cuve (plateau_R3 And &HFFFF&), (plateau_R3 \ (2 ^ 16)), type_message.Debut_trempe, type_lieu.CUVE4 'debut trempe cuve 4
            
            '================================================
            'PST1
            '================================================
                
            '3004_PST1_POSE
            Case 3004:
                [PIERCAN.ROBOTS.R3.BaseRotation] = 0
                [PIERCAN.ROBOTS.R3.ElbowRotation] = 360
                [PIERCAN.ROBOTS.R3.x_plateau] = 0
                [PIERCAN.ROBOTS.R3.y_plateau] = 0
              
        DoEvents
    End Select
    
    DoEvents
    
    If (code_cycle_anterieur_R3 = 3002) And ([PIERCAN.ROBOTS.R3.Etat_Job_Courant] <> 3002) Then
        'trace fin cuve 3
        Debug.Print ("trace trempe cuve 3")
        trace_cuve (plateau_R3 And &HFFFF&), (plateau_R3 \ (2 ^ 16)), type_message.Fin_trempe, type_lieu.CUVE3
        code_cycle_anterieur_R3 = 0
        passage_cuve_3 = True
    End If
    
    If (code_cycle_anterieur_R3 = 3003) And ([PIERCAN.ROBOTS.R3.Etat_Job_Courant] <> 3003) Then
        'trace fin cuve 4
        Debug.Print ("trace trempe cuve 4")
        trace_cuve (plateau_R3 And &HFFFF&), (plateau_R3 \ (2 ^ 16)), type_message.Fin_trempe, type_lieu.CUVE4
        code_cycle_anterieur_R3 = 0
        passage_cuve_4 = True
    End If
    
    If passage_cuve_3 <> True Or passage_cuve_4 <> True Then
        DoEvents
        code_cycle_anterieur_R3 = [PIERCAN.ROBOTS.R3.Etat_Job_Courant]
    Else
        passage_cuve_3 = False
        passage_cuve_4 = False
    End If
    
End Sub


Public Sub PCVUE_Etat_R4_Var_ValueChange()

    plateau_R4 = [PIERCAN.PLC.MW2500.MW2558]
    DoEvents
    
    Select Case [PIERCAN.ROBOTS.R4.Etat_Job_Courant]
        
        '================================================
        'R4
        '================================================
        
            '================================================
            'PST1
            '================================================
            '4001_PST1_PRISE
            Case 4001:
                [PIERCAN.ROBOTS.R4.BaseRotation] = 180
                [PIERCAN.ROBOTS.R4.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R4.XTranslationR4] = 60
                [PIERCAN.ROBOTS.R4.x_plateau] = 0
                [PIERCAN.ROBOTS.R4.y_plateau] = 0
            
                '================================================
                'CUVE5
                '================================================
                    
            '4002_CUVE5_TREMPE
            Case 4002:
                [PIERCAN.ROBOTS.R4.BaseRotation] = 151.2
                [PIERCAN.ROBOTS.R4.ElbowRotation] = 345.6
                [PIERCAN.ROBOTS.R4.XTranslationR4] = 32
                [PIERCAN.ROBOTS.R4.x_plateau] = 0
                [PIERCAN.ROBOTS.R4.y_plateau] = 0
                
                trace_cuve (plateau_R4 And &HFFFF&), (plateau_R4 \ (2 ^ 16)), type_message.Debut_trempe, type_lieu.CUVE5 'debut trempe cuve 5
            
            '================================================
            'PPNC
            '================================================
                
            '4003_PPNC_POSE_AB
            Case 4003:
                [PIERCAN.ROBOTS.R4.BaseRotation] = 284.4
                [PIERCAN.ROBOTS.R4.ElbowRotation] = 480
                [PIERCAN.ROBOTS.R4.XTranslationR4] = 400
                [PIERCAN.ROBOTS.R4.x_plateau] = 0
                [PIERCAN.ROBOTS.R4.y_plateau] = 0
             
            '4005_PPNC_PRISE_B  4009_PPNC_A_POSE_B  4010_PPNC_A_PRISE_A
            Case 4005, 4009, 4010:
                [PIERCAN.ROBOTS.R4.BaseRotation] = 284.4
                [PIERCAN.ROBOTS.R4.ElbowRotation] = 480
                [PIERCAN.ROBOTS.R4.XTranslationR4] = 338
                [PIERCAN.ROBOTS.R4.x_plateau] = 0
                [PIERCAN.ROBOTS.R4.y_plateau] = 0
                
            '4004_PPNC_PRISE_A
            Case 4004:
                [PIERCAN.ROBOTS.R4.BaseRotation] = 297
                [PIERCAN.ROBOTS.R4.ElbowRotation] = 465
                [PIERCAN.ROBOTS.R4.XTranslationR4] = 400
                [PIERCAN.ROBOTS.R4.x_plateau] = 0
                [PIERCAN.ROBOTS.R4.y_plateau] = 0
                
            '================================================
            ' four pre-sechage
            '================================================
                
            '4006_FOURPRE_ENTREE_POSE_B
            Case 4006:
                [PIERCAN.ROBOTS.R4.BaseRotation] = 25.2
                [PIERCAN.ROBOTS.R4.ElbowRotation] = 145
                [PIERCAN.ROBOTS.R4.XTranslationR4] = 4
                [PIERCAN.ROBOTS.R4.x_plateau] = 0
                [PIERCAN.ROBOTS.R4.y_plateau] = 0
                
            '4007_FOURPRE_SORTIE_PRISE_A
            Case 4007:
                [PIERCAN.ROBOTS.R4.BaseRotation] = 18
                [PIERCAN.ROBOTS.R4.ElbowRotation] = 115
                [PIERCAN.ROBOTS.R4.XTranslationR4] = 312
                [PIERCAN.ROBOTS.R4.x_plateau] = 0
                [PIERCAN.ROBOTS.R4.y_plateau] = 0
            
            '================================================
            'PST2
            '================================================
                
            '4008_PST2_POSE_A
            Case 4008:
                [PIERCAN.ROBOTS.R4.BaseRotation] = 244.8
                [PIERCAN.ROBOTS.R4.ElbowRotation] = 355
                [PIERCAN.ROBOTS.R4.XTranslationR4] = 232
                [PIERCAN.ROBOTS.R4.x_plateau] = 0
                [PIERCAN.ROBOTS.R4.y_plateau] = 0
                
                'plateau_R4 = [PIERCAN.PLC.MW2500.MW2564]
                'DoEvents
                    
        DoEvents
    End Select
    
    If (code_cycle_anterieur_R4 = 4002) And ([PIERCAN.ROBOTS.R4.Etat_Job_Courant] <> 4002) Then
        'trace fin cuve 5
        'Debug.Print ("trace trempe cuve 5")
        trace_cuve (plateau_R4 And &HFFFF&), (plateau_R4 \ (2 ^ 16)), type_message.Fin_trempe, type_lieu.CUVE5
        code_cycle_anterieur_R4 = 0
        passage_cuve_5 = True
    End If
    
    If passage_cuve_5 <> True Then
        DoEvents
        code_cycle_anterieur_R4 = [PIERCAN.ROBOTS.R4.Etat_Job_Courant]
    Else
        passage_cuve_5 = False
    End If
    
End Sub

Public Sub PCVUE_Etat_R5_Var_ValueChange()
    
    Select Case [PIERCAN.ROBOTS.R5.Etat_Job_Courant]
        
        '================================================
        'R5
        '================================================
        
            '================================================
            'PST2
            '================================================
            '5001_PST2_PRISE
            Case 5001:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 108
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                 
            '================================================
            'PPF
            '================================================
                
            
            '5003_PPF_POSE_B
            '5005_PPF_PRISE_B
            
            Case 5003, 5005:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 356.4
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
            
            '5002_PPF_POSE_A
            '5004_PPF_PRISE_A
            Case 5002, 5004:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 18
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                
            
            '================================================
            'PSTT1 PSTT2 PSTT3
            '================================================
                
        
            '5006_PSTT1_POSE_A
            Case 5006:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 270
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                
            '5008_PSTT2_POSE_A
            Case 5008:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 270
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
             
            '5007_PSTT1_POSE_B
            Case 5007:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 270
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                
            '5009_PSTT2_POSE_B
            Case 5009:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 270
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                
            '5010_PSTT1_PRISE_A
            Case 5010:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 270
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                
            '5011_PSTT1_PRISE_B
            Case 5011:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 270
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                    
            '5012_PSTT2_PRISE_A
            Case 5012:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 270
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
            
            '5013_PSTT2_PRISE_B
            Case 5013:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 270
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
            
            
            '================================================
            'FOUR
            '================================================
            
            '5014_FOUR_POSE_A
            Case 5014:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 126
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 50.4
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                
                    
            '5015_FOUR_POSE_B
            Case 5015:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 176.4
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                
            '5016_FOUR_POSE_C
            Case 5016:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 248.4
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 313.2
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                
                    
            '5017_FOUR_POSE_D
            Case 5017:
                [PIERCAN.ROBOTS.R5.BaseRotation] = 237.6
                [PIERCAN.ROBOTS.R5.ElbowRotation] = 0
                [PIERCAN.ROBOTS.R5.x_plateau] = 0
                [PIERCAN.ROBOTS.R5.y_plateau] = 0
                     
        DoEvents
    End Select
End Sub

'1
Private Sub inhibition_plateau_1_16_Var_ValueChange()
    Dim inhibition_plateau_1_16 As Long
    inhibition_plateau_1_16 = [PIERCAN.PLC.MW2000.MW2000]
    [PIERCAN.PLATEAU.inhibition.plateau1] = (inhibition_plateau_1_16 And (2 ^ 0)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau2] = (inhibition_plateau_1_16 And (2 ^ 1)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau3] = (inhibition_plateau_1_16 And (2 ^ 2)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau4] = (inhibition_plateau_1_16 And (2 ^ 3)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau5] = (inhibition_plateau_1_16 And (2 ^ 4)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau6] = (inhibition_plateau_1_16 And (2 ^ 5)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau7] = (inhibition_plateau_1_16 And (2 ^ 6)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau8] = (inhibition_plateau_1_16 And (2 ^ 7)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau9] = (inhibition_plateau_1_16 And (2 ^ 8)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau10] = (inhibition_plateau_1_16 And (2 ^ 9)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau11] = (inhibition_plateau_1_16 And (2 ^ 10)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau12] = (inhibition_plateau_1_16 And (2 ^ 11)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau13] = (inhibition_plateau_1_16 And (2 ^ 12)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau14] = (inhibition_plateau_1_16 And (2 ^ 13)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau15] = (inhibition_plateau_1_16 And (2 ^ 14)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau16] = (inhibition_plateau_1_16 And (2 ^ 15)) <> 0
    
    
End Sub

'2
Private Sub inhibition_plateau_17_32_Var_ValueChange()
    Dim inhibition_plateau_17_32 As Long
    inhibition_plateau_17_32 = [PIERCAN.PLC.MW2000.MW2002]
    [PIERCAN.PLATEAU.inhibition.plateau17] = (inhibition_plateau_17_32 And (2 ^ 0)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau18] = (inhibition_plateau_17_32 And (2 ^ 1)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau19] = (inhibition_plateau_17_32 And (2 ^ 2)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau20] = (inhibition_plateau_17_32 And (2 ^ 3)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau21] = (inhibition_plateau_17_32 And (2 ^ 4)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau22] = (inhibition_plateau_17_32 And (2 ^ 5)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau23] = (inhibition_plateau_17_32 And (2 ^ 6)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau24] = (inhibition_plateau_17_32 And (2 ^ 7)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau25] = (inhibition_plateau_17_32 And (2 ^ 8)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau26] = (inhibition_plateau_17_32 And (2 ^ 9)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau27] = (inhibition_plateau_17_32 And (2 ^ 10)) <> 0
    [PIERCAN.PLATEAU.inhibition.plateau28] = (inhibition_plateau_17_32 And (2 ^ 11)) <> 0
    
End Sub



'191
Private Sub changer_plateau_1_16_Var_ValueChange()
    Dim changer_plateau_1_16 As Long
    changer_plateau_1_16 = [PIERCAN.PLC.MW2000.MW2042]
    [PIERCAN.PLATEAU.changer.plateau1] = (changer_plateau_1_16 And (2 ^ 0)) <> 0
    [PIERCAN.PLATEAU.changer.plateau2] = (changer_plateau_1_16 And (2 ^ 1)) <> 0
    [PIERCAN.PLATEAU.changer.plateau3] = (changer_plateau_1_16 And (2 ^ 2)) <> 0
    [PIERCAN.PLATEAU.changer.plateau4] = (changer_plateau_1_16 And (2 ^ 3)) <> 0
    [PIERCAN.PLATEAU.changer.plateau5] = (changer_plateau_1_16 And (2 ^ 4)) <> 0
    [PIERCAN.PLATEAU.changer.plateau6] = (changer_plateau_1_16 And (2 ^ 5)) <> 0
    [PIERCAN.PLATEAU.changer.plateau7] = (changer_plateau_1_16 And (2 ^ 6)) <> 0
    [PIERCAN.PLATEAU.changer.plateau8] = (changer_plateau_1_16 And (2 ^ 7)) <> 0
    [PIERCAN.PLATEAU.changer.plateau9] = (changer_plateau_1_16 And (2 ^ 8)) <> 0
    [PIERCAN.PLATEAU.changer.plateau10] = (changer_plateau_1_16 And (2 ^ 9)) <> 0
    [PIERCAN.PLATEAU.changer.plateau11] = (changer_plateau_1_16 And (2 ^ 10)) <> 0
    [PIERCAN.PLATEAU.changer.plateau12] = (changer_plateau_1_16 And (2 ^ 11)) <> 0
    [PIERCAN.PLATEAU.changer.plateau13] = (changer_plateau_1_16 And (2 ^ 12)) <> 0
    [PIERCAN.PLATEAU.changer.plateau14] = (changer_plateau_1_16 And (2 ^ 13)) <> 0
    [PIERCAN.PLATEAU.changer.plateau15] = (changer_plateau_1_16 And (2 ^ 14)) <> 0
    [PIERCAN.PLATEAU.changer.plateau16] = (changer_plateau_1_16 And (2 ^ 15)) <> 0
    
    DoEvents
    
    For i = 1 To 16
        
        list_plateaux_en_cours(i).chdp = Variables("PIERCAN.PLATEAU.changer.plateau" & i)
    Next i
    
    
End Sub

'192
Private Sub changer_plateau_17_32_Var_ValueChange()
    Dim changer_plateau_17_32 As Long
    changer_plateau_17_32 = [PIERCAN.PLC.MW2000.MW2044]
    [PIERCAN.PLATEAU.changer.plateau17] = (changer_plateau_17_32 And (2 ^ 0)) <> 0
    [PIERCAN.PLATEAU.changer.plateau18] = (changer_plateau_17_32 And (2 ^ 1)) <> 0
    [PIERCAN.PLATEAU.changer.plateau19] = (changer_plateau_17_32 And (2 ^ 2)) <> 0
    [PIERCAN.PLATEAU.changer.plateau20] = (changer_plateau_17_32 And (2 ^ 3)) <> 0
    [PIERCAN.PLATEAU.changer.plateau21] = (changer_plateau_17_32 And (2 ^ 4)) <> 0
    [PIERCAN.PLATEAU.changer.plateau22] = (changer_plateau_17_32 And (2 ^ 5)) <> 0
    [PIERCAN.PLATEAU.changer.plateau23] = (changer_plateau_17_32 And (2 ^ 6)) <> 0
    [PIERCAN.PLATEAU.changer.plateau24] = (changer_plateau_17_32 And (2 ^ 7)) <> 0
    [PIERCAN.PLATEAU.changer.plateau25] = (changer_plateau_17_32 And (2 ^ 8)) <> 0
    [PIERCAN.PLATEAU.changer.plateau26] = (changer_plateau_17_32 And (2 ^ 9)) <> 0
    [PIERCAN.PLATEAU.changer.plateau27] = (changer_plateau_17_32 And (2 ^ 10)) <> 0
    [PIERCAN.PLATEAU.changer.plateau28] = (changer_plateau_17_32 And (2 ^ 11)) <> 0
    
    DoEvents
    
    For i = 17 To 28
        list_plateaux_en_cours(i).chdp = Variables("PIERCAN.PLATEAU.changer.plateau" & i)
    Next i
    
End Sub


'191
Private Sub plateau_fini_1_16_Var_ValueChange()
    Dim plateau_fini_1_16 As Long
    plateau_fini_1_16 = [PIERCAN.PLC.MW2500.MW2680]
    [PIERCAN.PLATEAU.fini.plateau1] = (plateau_fini_1_16 And (2 ^ 0)) <> 0
    [PIERCAN.PLATEAU.fini.plateau2] = (plateau_fini_1_16 And (2 ^ 1)) <> 0
    [PIERCAN.PLATEAU.fini.plateau3] = (plateau_fini_1_16 And (2 ^ 2)) <> 0
    [PIERCAN.PLATEAU.fini.plateau4] = (plateau_fini_1_16 And (2 ^ 3)) <> 0
    [PIERCAN.PLATEAU.fini.plateau5] = (plateau_fini_1_16 And (2 ^ 4)) <> 0
    [PIERCAN.PLATEAU.fini.plateau6] = (plateau_fini_1_16 And (2 ^ 5)) <> 0
    [PIERCAN.PLATEAU.fini.plateau7] = (plateau_fini_1_16 And (2 ^ 6)) <> 0
    [PIERCAN.PLATEAU.fini.plateau8] = (plateau_fini_1_16 And (2 ^ 7)) <> 0
    [PIERCAN.PLATEAU.fini.plateau9] = (plateau_fini_1_16 And (2 ^ 8)) <> 0
    [PIERCAN.PLATEAU.fini.plateau10] = (plateau_fini_1_16 And (2 ^ 9)) <> 0
    [PIERCAN.PLATEAU.fini.plateau11] = (plateau_fini_1_16 And (2 ^ 10)) <> 0
    [PIERCAN.PLATEAU.fini.plateau12] = (plateau_fini_1_16 And (2 ^ 11)) <> 0
    [PIERCAN.PLATEAU.fini.plateau13] = (plateau_fini_1_16 And (2 ^ 12)) <> 0
    [PIERCAN.PLATEAU.fini.plateau14] = (plateau_fini_1_16 And (2 ^ 13)) <> 0
    [PIERCAN.PLATEAU.fini.plateau15] = (plateau_fini_1_16 And (2 ^ 14)) <> 0
    [PIERCAN.PLATEAU.fini.plateau16] = (plateau_fini_1_16 And (2 ^ 15)) <> 0
    
End Sub

'192
Private Sub plateau_fini_17_32_Var_ValueChange()
    Dim plateau_fini_17_32 As Long
    plateau_fini_17_32 = [PIERCAN.PLC.MW2500.MW2682]
    [PIERCAN.PLATEAU.fini.plateau17] = (plateau_fini_17_32 And (2 ^ 0)) <> 0
    [PIERCAN.PLATEAU.fini.plateau18] = (plateau_fini_17_32 And (2 ^ 1)) <> 0
    [PIERCAN.PLATEAU.fini.plateau19] = (plateau_fini_17_32 And (2 ^ 2)) <> 0
    [PIERCAN.PLATEAU.fini.plateau20] = (plateau_fini_17_32 And (2 ^ 3)) <> 0
    [PIERCAN.PLATEAU.fini.plateau21] = (plateau_fini_17_32 And (2 ^ 4)) <> 0
    [PIERCAN.PLATEAU.fini.plateau22] = (plateau_fini_17_32 And (2 ^ 5)) <> 0
    [PIERCAN.PLATEAU.fini.plateau23] = (plateau_fini_17_32 And (2 ^ 6)) <> 0
    [PIERCAN.PLATEAU.fini.plateau24] = (plateau_fini_17_32 And (2 ^ 7)) <> 0
    [PIERCAN.PLATEAU.fini.plateau25] = (plateau_fini_17_32 And (2 ^ 8)) <> 0
    [PIERCAN.PLATEAU.fini.plateau26] = (plateau_fini_17_32 And (2 ^ 9)) <> 0
    [PIERCAN.PLATEAU.fini.plateau27] = (plateau_fini_17_32 And (2 ^ 10)) <> 0
    [PIERCAN.PLATEAU.fini.plateau28] = (plateau_fini_17_32 And (2 ^ 11)) <> 0
    
End Sub


'5
Private Sub Etat_Couv_Cuve_Var_ValueChange()
    Dim Etat_Couv_Cuve As Long
    Etat_Couv_Cuve = [PIERCAN.PLC.MW2500.MW2500]
    [PIERCAN.CUVES.CUVE1.ETAT_VERO] = (Etat_Couv_Cuve And (2 ^ 0)) <> 0
    [PIERCAN.CUVES.CUVE1.ETAT_VERF] = (Etat_Couv_Cuve And (2 ^ 1)) <> 0
    [PIERCAN.CUVES.CUVE2.ETAT_VERO] = (Etat_Couv_Cuve And (2 ^ 2)) <> 0
    [PIERCAN.CUVES.CUVE2.ETAT_VERF] = (Etat_Couv_Cuve And (2 ^ 3)) <> 0
    [PIERCAN.CUVES.CUVE3.ETAT_VERO] = (Etat_Couv_Cuve And (2 ^ 4)) <> 0
    [PIERCAN.CUVES.CUVE3.ETAT_VERF] = (Etat_Couv_Cuve And (2 ^ 5)) <> 0
    [PIERCAN.CUVES.CUVE4.ETAT_VERO] = (Etat_Couv_Cuve And (2 ^ 6)) <> 0
    [PIERCAN.CUVES.CUVE4.ETAT_VERF] = (Etat_Couv_Cuve And (2 ^ 7)) <> 0
    [PIERCAN.CUVES.CUVE5.ETAT_VERO] = (Etat_Couv_Cuve And (2 ^ 8)) <> 0
    [PIERCAN.CUVES.CUVE5.ETAT_VERF] = (Etat_Couv_Cuve And (2 ^ 9)) <> 0
    [PIERCAN.POSAGE.PSCOAG.Porte_R2_O] = (Etat_Couv_Cuve And (2 ^ 10)) <> 0
    [PIERCAN.POSAGE.PSCOAG.Porte_R2_F] = (Etat_Couv_Cuve And (2 ^ 11)) <> 0
    [PIERCAN.POSAGE.PSCOAG.Porte_R3_O] = (Etat_Couv_Cuve And (2 ^ 12)) <> 0
    [PIERCAN.POSAGE.PSCOAG.Porte_R3_F] = (Etat_Couv_Cuve And (2 ^ 13)) <> 0
    [PIERCAN.DEMOULAGE.Porte_O] = (Etat_Couv_Cuve And (2 ^ 14)) <> 0
End Sub

'6
Private Sub Etat_Agit_Cuve_Var_ValueChange()
    Dim Etat_Agit_Cuve As Long
    Etat_Agit_Cuve = [PIERCAN.PLC.MW2500.MW2502]
    [PIERCAN.CUVES.CUVE1.ETAT_AGITALARM] = (Etat_Agit_Cuve And (2 ^ 0)) <> 0
    [PIERCAN.CUVES.CUVE2.ETAT_AGITALARM] = (Etat_Agit_Cuve And (2 ^ 1)) <> 0
    [PIERCAN.CUVES.CUVE3.ETAT_AGITALARM] = (Etat_Agit_Cuve And (2 ^ 2)) <> 0
    [PIERCAN.CUVES.CUVE4.ETAT_AGITALARM] = (Etat_Agit_Cuve And (2 ^ 3)) <> 0
    [PIERCAN.CUVES.CUVE5.ETAT_AGITALARM] = (Etat_Agit_Cuve And (2 ^ 4)) <> 0
    [PIERCAN.CUVES.CUVE1.ETAT_AGIT] = (Etat_Agit_Cuve And (2 ^ 5)) <> 0
    [PIERCAN.CUVES.CUVE2.ETAT_AGIT] = (Etat_Agit_Cuve And (2 ^ 6)) <> 0
    [PIERCAN.CUVES.CUVE3.ETAT_AGIT] = (Etat_Agit_Cuve And (2 ^ 7)) <> 0
    [PIERCAN.CUVES.CUVE4.ETAT_AGIT] = (Etat_Agit_Cuve And (2 ^ 8)) <> 0
    [PIERCAN.CUVES.CUVE5.ETAT_AGIT] = (Etat_Agit_Cuve And (2 ^ 9)) <> 0
    [PIERCAN.CYCLE.En_cycle_R1] = (Etat_Agit_Cuve And (2 ^ 10)) <> 0
    [PIERCAN.CYCLE.En_cycle_R2_R3_R4] = (Etat_Agit_Cuve And (2 ^ 11)) <> 0 'Api en cycle R2 R3 R4
    '[PIERCAN.CYCLE.En_cycle_R3] = (Etat_Agit_Cuve And (2 ^ 12)) <> 0
    [PIERCAN.CYCLE.En_fin_de_cycle_R2_R3_R4] = (Etat_Agit_Cuve And (2 ^ 13)) <> 0 'Api fin de cycle R2 R3 R4
    [PIERCAN.CYCLE.En_cycle_R5] = (Etat_Agit_Cuve And (2 ^ 14)) <> 0
    [PIERCAN.CYCLE.Dechargement_en_cours] = (Etat_Agit_Cuve And (2 ^ 15)) <> 0
End Sub

'7
Private Sub Etat_IBC_Cuve_Var_ValueChange()
    Dim Etat_IBC_Cuve_Var As Long
    Etat_IBC_Cuve_Var = [PIERCAN.PLC.MW2500.MW2504]
    [PIERCAN.cuves.CUVE1.IBC.ETAT_AGITALARM] = (Etat_IBC_Cuve_Var And (2 ^ 0)) <> 0
    [PIERCAN.cuves.CUVE3.IBC.ETAT_AGITALARM] = (Etat_IBC_Cuve_Var And (2 ^ 1)) <> 0
    [PIERCAN.cuves.CUVE4.IBC.ETAT_AGITALARM] = (Etat_IBC_Cuve_Var And (2 ^ 2)) <> 0
    [PIERCAN.CUVES.CUVE1.IBC.ETAT_AGIT] = (Etat_IBC_Cuve_Var And (2 ^ 3)) <> 0
    [PIERCAN.CUVES.CUVE3.IBC.ETAT_AGIT] = (Etat_IBC_Cuve_Var And (2 ^ 4)) <> 0
    [PIERCAN.CUVES.CUVE4.IBC.ETAT_AGIT] = (Etat_IBC_Cuve_Var And (2 ^ 5)) <> 0
    [PIERCAN.CUVES.CUVE2.ETAT_CHAUFFE] = (Etat_IBC_Cuve_Var And (2 ^ 6)) <> 0
    [PIERCAN.CUVES.CUVE5.ETAT_CHAUFFE] = (Etat_IBC_Cuve_Var And (2 ^ 7)) <> 0
    [PIERCAN.CUVES.CUVE1.ETAT_EN_REMPLISSAGE] = (Etat_IBC_Cuve_Var And (2 ^ 8)) <> 0
    [PIERCAN.CUVES.CUVE2.ETAT_EN_REMPLISSAGE] = (Etat_IBC_Cuve_Var And (2 ^ 9)) <> 0
    [PIERCAN.CUVES.CUVE3.ETAT_EN_REMPLISSAGE] = (Etat_IBC_Cuve_Var And (2 ^ 10)) <> 0
    [PIERCAN.CUVES.CUVE4.ETAT_EN_REMPLISSAGE] = (Etat_IBC_Cuve_Var And (2 ^ 11)) <> 0
    [PIERCAN.CUVES.CUVE5.ETAT_EN_REMPLISSAGE] = (Etat_IBC_Cuve_Var And (2 ^ 12)) <> 0
End Sub



'Private Sub Presence_Cuve_Var_ValueChange()
    'Debug.Print ("cuve changer : " & [PIERCAN.PLC.MW2000.MW2066])
'End Sub


'39
Private Sub EmplRef_1_2_Var_ValueChange()

    Dim EmplRef_1_2_Var As Double
    EmplRef_1_2_Var = [PIERCAN.PLC.MW2500.MW2544]

    [PIERCAN.PLATEAU.NumPlateauRefroidissement1D] = EmplRef_1_2_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauRefroidissement2D] = ((EmplRef_1_2_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauRefroidissement1] = EmplRef_1_2_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauRefroidissement2] = ((EmplRef_1_2_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_1_2_Var And &HFFFF&), ((EmplRef_1_2_Var \ (2 ^ 16)) And &HFFFF&), "PR3 A", "PR3 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PR3_A, 0, trac_ok_var
    
End Sub

'40
Private Sub EmplRef_3_4_Var_ValueChange()

    Dim EmplRef_3_4_Var As Double
    EmplRef_3_4_Var = [PIERCAN.PLC.MW2500.MW2546]

    [PIERCAN.PLATEAU.NumPlateauRefroidissement3D] = EmplRef_3_4_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauRefroidissement4D] = ((EmplRef_3_4_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauRefroidissement3] = EmplRef_3_4_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauRefroidissement4] = ((EmplRef_3_4_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_3_4_Var And &HFFFF&), ((EmplRef_3_4_Var \ (2 ^ 16)) And &HFFFF&), "PR2 A", "PR2 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PR2_A, 0, trac_ok_var

End Sub

'41
Private Sub EmplRef_5_6_Var_ValueChange()

    Dim EmplRef_5_6_Var As Double
    EmplRef_5_6_Var = [PIERCAN.PLC.MW2500.MW2548]

    [PIERCAN.PLATEAU.NumPlateauRefroidissement5D] = EmplRef_5_6_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauRefroidissement6D] = ((EmplRef_5_6_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauRefroidissement5] = EmplRef_5_6_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauRefroidissement6] = ((EmplRef_5_6_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_5_6_Var And &HFFFF&), ((EmplRef_5_6_Var \ (2 ^ 16)) And &HFFFF&), "PR1 A", "PR1 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PR1_A, 0, trac_ok_var

End Sub

'42
Private Sub EmplRef_7_8_Var_ValueChange()

    Dim EmplRef_7_8_Var As Double
    EmplRef_7_8_Var = [PIERCAN.PLC.MW2500.MW2550]

    [PIERCAN.PLATEAU.NumPlateauCDT1D] = EmplRef_7_8_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauDemoulage1D] = ((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauCDT1] = EmplRef_7_8_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauDemoulage1] = ((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&)
    
    
    
    'nb passage trempe
    If list_plateaux_en_cours(((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&) \ 10).chdp = True Then
        Update_nb_passage_trempe (((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&) \ 10), True
        list_plateaux_en_cours(((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&) \ 10).nb_passage_trempe = 0
        list_plateaux_a_suivre(((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&) \ 10).nb_passage_trempe = 0
        'Debug.Print ("raz numero plateau nb trempe : " & (((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&) \ 10))
    End If
    
    'update date fin of au demoulage
    If trac_ok_var = True And ((((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&)) >= 11 And (((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&)) <= 282) And list_plateaux_en_cours(((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&) \ 10).annule = False Then
      Update_date_Affaire list_plateaux_en_cours((((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&)) \ 10).of, 1
    End If
    
    etat_plateau (EmplRef_7_8_Var And &HFFFF&), ((EmplRef_7_8_Var \ (2 ^ 16)) And &HFFFF&), "Demoulage", "Talcage", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.Zone_Talcage, type_lieu.Zone_Demoulage, trac_ok_var
    
End Sub

'43
Private Sub EmplRef_9_10_Var_ValueChange()

    Dim EmplRef_9_10_Var As Double
    EmplRef_9_10_Var = [PIERCAN.PLC.MW2500.MW2552]

    [PIERCAN.PLATEAU.NumPlateauR1D] = EmplRef_9_10_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauR5D] = ((EmplRef_9_10_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauR1] = EmplRef_9_10_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauR5] = ((EmplRef_9_10_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_9_10_Var And &HFFFF&), ((EmplRef_9_10_Var \ (2 ^ 16)) And &HFFFF&), "Sur le robot R1", "Sur le robot R5", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.R1, type_lieu.R5, trac_ok_var

End Sub

'44
Private Sub EmplRef_11_12_Var_ValueChange()

    Dim EmplRef_11_12_Var As Double
    EmplRef_11_12_Var = [PIERCAN.PLC.MW2500.MW2554]

    [PIERCAN.PLATEAU.NumPlateauR2_1D] = EmplRef_11_12_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauR2_2D] = ((EmplRef_11_12_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauR2_1] = EmplRef_11_12_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauR2_2] = ((EmplRef_11_12_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_11_12_Var And &HFFFF&), ((EmplRef_11_12_Var \ (2 ^ 16)) And &HFFFF&), "Sur le robot R2 A", "Sur le robot R2 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.R2_A, 0, trac_ok_var

End Sub

'45
Private Sub EmplRef_13_14_Var_ValueChange()

    Dim EmplRef_13_14_Var As Double
    EmplRef_13_14_Var = [PIERCAN.PLC.MW2500.MW2556]

    [PIERCAN.PLATEAU.NumPlateauR3_1D] = EmplRef_13_14_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauR3_2D] = ((EmplRef_13_14_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauR3_1] = EmplRef_13_14_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauR3_2] = ((EmplRef_13_14_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_13_14_Var And &HFFFF&), ((EmplRef_13_14_Var \ (2 ^ 16)) And &HFFFF&), "Sur le robot R3 A", "Sur le robot R3 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.R3_A, 0, trac_ok_var

End Sub

'46
Private Sub EmplRef_15_16_Var_ValueChange()

    Dim EmplRef_15_16_Var As Double
    EmplRef_15_16_Var = [PIERCAN.PLC.MW2500.MW2558]

    [PIERCAN.PLATEAU.NumPlateauR4_1D] = EmplRef_15_16_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauR4_2D] = ((EmplRef_15_16_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauR4_1] = EmplRef_15_16_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauR4_2] = ((EmplRef_15_16_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_15_16_Var And &HFFFF&), ((EmplRef_15_16_Var \ (2 ^ 16)) And &HFFFF&), "Sur le robot R4 A", "Sur le robot R4 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.R4_A, type_lieu.R4_B, trac_ok_var

End Sub

'47
Private Sub EmplRef_17_18_Var_ValueChange()

    Dim EmplRef_17_18_Var As Double
    EmplRef_17_18_Var = [PIERCAN.PLC.MW2500.MW2560]
    DoEvents

    [PIERCAN.PLATEAU.NumPlateauSRIN1_1D] = EmplRef_17_18_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauSRIN1_2D] = ((EmplRef_17_18_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauSRIN1_1] = EmplRef_17_18_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauSRIN1_2] = ((EmplRef_17_18_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_17_18_Var And &HFFFF&), ((EmplRef_17_18_Var \ (2 ^ 16)) And &HFFFF&), "PSR1 A", "PSR1 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PSR1_A, 0, trac_ok_var

    'update date debut of
    If trac_ok_var = True Then
      Update_date_Affaire list_plateaux_en_cours(((EmplRef_17_18_Var And &HFFFF&)) \ 10).of, 0
    End If
    
End Sub

'48
Private Sub EmplRef_19_20_Var_ValueChange()

    Dim EmplRef_19_20_Var As Double
    EmplRef_19_20_Var = [PIERCAN.PLC.MW2500.MW2562]

    [PIERCAN.PLATEAU.NumPlateauSRIN2_1D] = EmplRef_19_20_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauSRIN2_2D] = ((EmplRef_19_20_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauSRIN2_1] = EmplRef_19_20_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauSRIN2_2] = ((EmplRef_19_20_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_19_20_Var And &HFFFF&), ((EmplRef_19_20_Var \ (2 ^ 16)) And &HFFFF&), "PSR2 A", "PSR2 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PSR2_A, 0, trac_ok_var

End Sub

'49 - RESERVE
Private Sub EmplRef_21_22_Var_ValueChange()

    Dim EmplRef_21_22_Var As Double
    EmplRef_21_22_Var = [PIERCAN.PLC.MW2500.MW2564]
    
    
    [PIERCAN.PLATEAU.NumPlateauPS3D] = EmplRef_21_22_Var And &HFFFF&
    '[reserve] = ((EmplRef_21_22_Var \ (2 ^ 16)) And &HFFFF&)
    
    [PIERCAN.PLATEAU.NumPlateauPS3] = EmplRef_21_22_Var And &HFFFF&
    
    If EmplRef_21_22_Var <> 0 Then
        
        If EmplRef_21_22_Var Mod 10 = 1 Then
            list_plateaux_en_cours(EmplRef_21_22_Var \ 10).etat_1 = "PST2"
        Else
            list_plateaux_en_cours(EmplRef_21_22_Var \ 10).etat_2 = "PST2"
        End If
       
        If trac_ok_var = True Then
            Trace list_plateaux_en_cours((EmplRef_21_22_Var And &HFFFF&) \ 10).of, list_plateaux_en_cours((EmplRef_21_22_Var And &HFFFF&) \ 10).affaire, type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PST2, "", 0, list_plateaux_en_cours((EmplRef_21_22_Var And &HFFFF&) \ 10).code_art, list_plateaux_en_cours((EmplRef_21_22_Var And &HFFFF&) \ 10).version_cdt, ((EmplRef_21_22_Var And &HFFFF&) \ 10)
        End If
    End If

End Sub

'50
Private Sub EmplRef_23_24_Var_ValueChange()

    Dim EmplRef_23_24_Var As Double
    
    EmplRef_23_24_Var = [PIERCAN.PLC.MW2500.MW2566]

    [PIERCAN.PLATEAU.NumPlateauSCOAG_1D] = EmplRef_23_24_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauSCOAG_2D] = ((EmplRef_23_24_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauSCOAG_1] = EmplRef_23_24_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauSCOAG_2] = ((EmplRef_23_24_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_23_24_Var And &HFFFF&), ((EmplRef_23_24_Var \ (2 ^ 16)) And &HFFFF&), "PCOAG A", "PCOAG B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PCOAG_A, 0, trac_ok_var

End Sub

'51
Private Sub EmplRef_25_26_Var_ValueChange()

    Dim EmplRef_25_26_Var As Double
    EmplRef_25_26_Var = [PIERCAN.PLC.MW2500.MW2568]

    [PIERCAN.PLATEAU.NumPlateauPS2_1D] = EmplRef_25_26_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauPS2_2D] = ((EmplRef_25_26_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauPS2_1] = EmplRef_25_26_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauPS2_2] = ((EmplRef_25_26_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_25_26_Var And &HFFFF&), ((EmplRef_23_24_Var \ (2 ^ 16)) And &HFFFF&), "PST1 A", "PST1 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PST1_A, 0, trac_ok_var

End Sub

'52
Private Sub EmplRef_27_28_Var_ValueChange()

    Dim EmplRef_27_28_Var As Double
    EmplRef_27_28_Var = [PIERCAN.PLC.MW2500.MW2570]

    [PIERCAN.PLATEAU.NumPlateauT1D] = EmplRef_27_28_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauT2D] = ((EmplRef_27_28_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauT1] = EmplRef_27_28_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauT2] = ((EmplRef_27_28_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_27_28_Var And &HFFFF&), ((EmplRef_27_28_Var \ (2 ^ 16)) And &HFFFF&), "PSTT1 A", "PSTT1 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PSTT1_A, 0, trac_ok_var

End Sub

'53
Private Sub EmplRef_29_30_Var_ValueChange()

    Dim EmplRef_29_30_Var As Double
    EmplRef_29_30_Var = [PIERCAN.PLC.MW2500.MW2572]

    [PIERCAN.PLATEAU.NumPlateauT3D] = EmplRef_29_30_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauT4D] = ((EmplRef_29_30_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauT3] = EmplRef_29_30_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauT4] = ((EmplRef_29_30_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_29_30_Var And &HFFFF&), ((EmplRef_29_30_Var \ (2 ^ 16)) And &HFFFF&), "PSTT2 A", "PSTT2 B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.PSTT2_A, 0, trac_ok_var

End Sub

'54
Private Sub EmplRef_31_32_Var_ValueChange()

    Dim EmplRef_31_32_Var As Double
    EmplRef_31_32_Var = [PIERCAN.PLC.MW2500.MW2574]

    [PIERCAN.PLATEAU.NumPlateauPPF1D] = EmplRef_31_32_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauPPF2D] = ((EmplRef_31_32_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauPPF1] = EmplRef_31_32_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauPPF2] = ((EmplRef_31_32_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_31_32_Var And &HFFFF&), ((EmplRef_31_32_Var \ (2 ^ 16)) And &HFFFF&), "PPF A", "PPF B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.zone_PPF_A, 0, trac_ok_var

End Sub

'55
Private Sub EmplRef_33_34_Var_ValueChange()

    Dim EmplRef_33_34_Var As Double
    EmplRef_33_34_Var = [PIERCAN.PLC.MW2500.MW2576]

    [PIERCAN.PLATEAU.NumPlateauPPNC1D] = EmplRef_33_34_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauPPNC2D] = ((EmplRef_33_34_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauPPNC1] = EmplRef_33_34_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauPPNC2] = ((EmplRef_33_34_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_33_34_Var And &HFFFF&), ((EmplRef_33_34_Var \ (2 ^ 16)) And &HFFFF&), "PPNC A", "PPNC B", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.zone_PPNC_A, 0, trac_ok_var

End Sub

'56 - RESERVE
Private Sub EmplRef_35_36_Var_ValueChange()

    Dim EmplRef_35_36_Var As Double
    EmplRef_35_36_Var = [PIERCAN.PLC.MW2500.MW2578]
    
    [PIERCAN.PLATEAU.NumPlateauFourPS1D] = EmplRef_35_36_Var And &HFFFF&
    '[reserve] = ((EmplRef_35_36_Var \ (2 ^ 16)) And &HFFFF&)
    
    [PIERCAN.PLATEAU.NumPlateauFourPS1] = EmplRef_35_36_Var And &HFFFF&
    
    If EmplRef_35_36_Var <> 0 Then
        
        If EmplRef_35_36_Var Mod 10 = 1 Then
            list_plateaux_en_cours(EmplRef_35_36_Var \ 10).etat_1 = "Entree du four de pre-sechage"
        Else
            list_plateaux_en_cours(EmplRef_35_36_Var \ 10).etat_2 = "Entree du four de pre-sechage"
        End If
        
        If (trac_ok_var = True) Then
            Trace list_plateaux_en_cours((EmplRef_35_36_Var And &HFFFF&) \ 10).of, list_plateaux_en_cours((EmplRef_35_36_Var And &HFFFF&) \ 10).affaire, type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Debut_chauffe, type_equipement.PS, type_lieu.Four_pre_sech, "", 0, list_plateaux_en_cours((EmplRef_35_36_Var And &HFFFF&) \ 10).code_art, list_plateaux_en_cours((EmplRef_35_36_Var And &HFFFF&) \ 10).version_cdt, ((EmplRef_35_36_Var And &HFFFF&) \ 10)
        End If
        
    End If

End Sub

'57
Private Sub EmplRef_37_38_Var_ValueChange()

    Dim EmplRef_37_38_Var As Double
    EmplRef_37_38_Var = [PIERCAN.PLC.MW2500.MW2580]

    [PIERCAN.PLATEAU.NumPlateauFourPS2D] = EmplRef_37_38_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFourPS3D] = ((EmplRef_37_38_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFourPS2] = EmplRef_37_38_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFourPS3] = ((EmplRef_37_38_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_37_38_Var And &HFFFF&), ((EmplRef_37_38_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four de pre-sechage", "Dans le four de pre-sechage", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.Four_pre_sech, type_lieu.Four_pre_sech, False

End Sub

'58
Private Sub EmplRef_39_40_Var_ValueChange()

    Dim EmplRef_39_40_Var As Double
    EmplRef_39_40_Var = [PIERCAN.PLC.MW2500.MW2582]

    [PIERCAN.PLATEAU.NumPlateauFourPS4D] = EmplRef_39_40_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFourPS5D] = ((EmplRef_39_40_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFourPS4] = EmplRef_39_40_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFourPS5] = ((EmplRef_39_40_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_39_40_Var And &HFFFF&), ((EmplRef_39_40_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four de pre-sechage", "Dans le four de pre-sechage", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.Four_pre_sech, type_lieu.Four_pre_sech, False
End Sub

'59
Private Sub EmplRef_41_42_Var_ValueChange()

    Dim EmplRef_41_42_Var As Double
    EmplRef_41_42_Var = [PIERCAN.PLC.MW2500.MW2584]

    [PIERCAN.PLATEAU.NumPlateauFourPS6D] = EmplRef_41_42_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFourPS7D] = ((EmplRef_41_42_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFourPS6] = EmplRef_41_42_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFourPS7] = ((EmplRef_41_42_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_41_42_Var And &HFFFF&), ((EmplRef_41_42_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four de pre-sechage", "Dans le four de pre-sechage", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.Four_pre_sech, type_lieu.Four_pre_sech, False

End Sub

'60
Private Sub EmplRef_43_44_Var_ValueChange()

    Dim EmplRef_43_44_Var As Double
    EmplRef_43_44_Var = [PIERCAN.PLC.MW2500.MW2586]

    [PIERCAN.PLATEAU.NumPlateauFourPS8D] = EmplRef_43_44_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFourPS9D] = ((EmplRef_43_44_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFourPS8] = EmplRef_43_44_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFourPS9] = ((EmplRef_43_44_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_43_44_Var And &HFFFF&), ((EmplRef_43_44_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four de pre-sechage", "Dans le four de pre-sechage", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Deplacement, type_equipement.PS, type_lieu.Four_pre_sech, type_lieu.Four_pre_sech, False

End Sub

'61 - RESERVE
Private Sub EmplRef_45_46_Var_ValueChange()

    Dim EmplRef_45_46_Var As Double
    EmplRef_45_46_Var = [PIERCAN.PLC.MW2500.MW2588]

    '[reserve] = EmplRef_45_46_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFourPS10D] = ((EmplRef_45_46_Var \ (2 ^ 16)) And &HFFFF&)
    
    [PIERCAN.PLATEAU.NumPlateauFourPS10] = ((EmplRef_45_46_Var \ (2 ^ 16)) And &HFFFF&)
    
    If EmplRef_45_46_Var <> 0 Then
        
       If EmplRef_45_46_Var Mod 10 = 1 Then
            list_plateaux_en_cours(((EmplRef_45_46_Var \ (2 ^ 16))) \ 10).etat_1 = "Sortie du four de pre-sechage"
            ''list_plateaux_en_cours(EmplRef_21_22_Var \ 10).etat_1 = "PST2"
        Else
            list_plateaux_en_cours(((EmplRef_45_46_Var \ (2 ^ 16))) \ 10).etat_2 = "Sortie du four de pre-sechage" 'TODO
        End If
        
        If (trac_ok_var = True) Then
            Trace list_plateaux_en_cours(((EmplRef_45_46_Var \ (2 ^ 16))) \ 10).of, list_plateaux_en_cours(((EmplRef_45_46_Var \ (2 ^ 16))) \ 10).affaire, type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Fin_chauffe, type_equipement.PS, type_lieu.Four_pre_sech, "", type_message.Deplacement, list_plateaux_en_cours(((EmplRef_45_46_Var \ (2 ^ 16))) \ 10).code_art, list_plateaux_en_cours(((EmplRef_45_46_Var \ (2 ^ 16))) \ 10).version_cdt, (((EmplRef_45_46_Var \ (2 ^ 16))) \ 10)
        End If
    End If

End Sub

'62
Private Sub EmplRef_47_48_Var_ValueChange()

    Dim EmplRef_47_48_Var As Double
    EmplRef_47_48_Var = [PIERCAN.PLC.MW2500.MW2590]

    [PIERCAN.PLATEAU.NumPlateauFour1D] = EmplRef_47_48_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour2D] = ((EmplRef_47_48_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour1] = EmplRef_47_48_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour2] = ((EmplRef_47_48_Var \ (2 ^ 16)) And &HFFFF&)
    
    
    etat_plateau (EmplRef_47_48_Var And &HFFFF&), ((EmplRef_47_48_Var \ (2 ^ 16)) And &HFFFF&), "Entree du four", "Entree du four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'63
Private Sub EmplRef_49_50_Var_ValueChange()

    Dim EmplRef_49_50_Var As Double
    EmplRef_49_50_Var = [PIERCAN.PLC.MW2500.MW2592]

    [PIERCAN.PLATEAU.NumPlateauFour3D] = EmplRef_49_50_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour4D] = ((EmplRef_49_50_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour3] = EmplRef_49_50_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour4] = ((EmplRef_49_50_Var \ (2 ^ 16)) And &HFFFF&)
    
    
    etat_plateau (EmplRef_49_50_Var And &HFFFF&), ((EmplRef_49_50_Var \ (2 ^ 16)) And &HFFFF&), "Entree du four", "Entree du four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'64
Private Sub EmplRef_51_52_Var_ValueChange()

    Dim EmplRef_51_52_Var As Double
    EmplRef_51_52_Var = [PIERCAN.PLC.MW2500.MW2594]

    [PIERCAN.PLATEAU.NumPlateauFour5D] = EmplRef_51_52_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour6D] = ((EmplRef_51_52_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour5] = EmplRef_51_52_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour6] = ((EmplRef_51_52_Var \ (2 ^ 16)) And &HFFFF&)
    
    'debut zone 1 CV1
    etat_plateau (EmplRef_51_52_Var And &HFFFF&), ((EmplRef_51_52_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Debut_chauffe_zone_1, type_equipement.PS, type_lieu.Four, 0, trac_ok_var
    

End Sub

'65
Private Sub EmplRef_53_54_Var_ValueChange()

    Dim EmplRef_53_54_Var As Double
    EmplRef_53_54_Var = [PIERCAN.PLC.MW2500.MW2596]

    [PIERCAN.PLATEAU.NumPlateauFour7D] = EmplRef_53_54_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour8D] = ((EmplRef_53_54_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour7] = EmplRef_53_54_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour8] = ((EmplRef_53_54_Var \ (2 ^ 16)) And &HFFFF&)
    
    'debut zone 1 CV2
    etat_plateau (EmplRef_53_54_Var And &HFFFF&), ((EmplRef_53_54_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Debut_chauffe_zone_1, type_equipement.PS, type_lieu.Four, 0, trac_ok_var

End Sub

'66
Private Sub EmplRef_55_56_Var_ValueChange()

    Dim EmplRef_55_56_Var As Double
    EmplRef_55_56_Var = [PIERCAN.PLC.MW2500.MW2598]

    [PIERCAN.PLATEAU.NumPlateauFour9D] = EmplRef_55_56_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour10D] = ((EmplRef_55_56_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour9] = EmplRef_55_56_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour10] = ((EmplRef_55_56_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_55_56_Var And &HFFFF&), ((EmplRef_55_56_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'67
Private Sub EmplRef_57_58_Var_ValueChange()

    Dim EmplRef_57_58_Var As Double
    EmplRef_57_58_Var = [PIERCAN.PLC.MW2500.MW2600]

    [PIERCAN.PLATEAU.NumPlateauFour11D] = EmplRef_57_58_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour12D] = ((EmplRef_57_58_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour11] = EmplRef_57_58_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour12] = ((EmplRef_57_58_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_57_58_Var And &HFFFF&), ((EmplRef_57_58_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'68
Private Sub EmplRef_59_60_Var_ValueChange()

    Dim EmplRef_59_60_Var As Double
    EmplRef_59_60_Var = [PIERCAN.PLC.MW2500.MW2602]

    [PIERCAN.PLATEAU.NumPlateauFour13D] = EmplRef_59_60_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour14D] = ((EmplRef_59_60_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour13] = EmplRef_59_60_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour14] = ((EmplRef_59_60_Var \ (2 ^ 16)) And &HFFFF&)
    
    
    etat_plateau (EmplRef_59_60_Var And &HFFFF&), ((EmplRef_59_60_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'69
Private Sub EmplRef_61_62_Var_ValueChange()

    Dim EmplRef_61_62_Var As Double
    EmplRef_61_62_Var = [PIERCAN.PLC.MW2500.MW2604]

    [PIERCAN.PLATEAU.NumPlateauFour15D] = EmplRef_61_62_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour16D] = ((EmplRef_61_62_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour15] = EmplRef_61_62_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour16] = ((EmplRef_61_62_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_61_62_Var And &HFFFF&), ((EmplRef_61_62_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'70
Private Sub EmplRef_63_64_Var_ValueChange()

    Dim EmplRef_63_64_Var As Double
    EmplRef_63_64_Var = [PIERCAN.PLC.MW2500.MW2606]

    [PIERCAN.PLATEAU.NumPlateauFour17D] = EmplRef_63_64_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour18D] = ((EmplRef_63_64_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour17] = EmplRef_63_64_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour18] = ((EmplRef_63_64_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_63_64_Var And &HFFFF&), ((EmplRef_63_64_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'71
Private Sub EmplRef_65_66_Var_ValueChange()

    Dim EmplRef_65_66_Var As Double
    EmplRef_65_66_Var = [PIERCAN.PLC.MW2500.MW2608]

    [PIERCAN.PLATEAU.NumPlateauFour19D] = EmplRef_65_66_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour20D] = ((EmplRef_65_66_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour19] = EmplRef_65_66_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour20] = ((EmplRef_65_66_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_65_66_Var And &HFFFF&), ((EmplRef_65_66_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'72
Private Sub EmplRef_67_68_Var_ValueChange()

    Dim EmplRef_67_68_Var As Double
    EmplRef_67_68_Var = [PIERCAN.PLC.MW2500.MW2610]

    [PIERCAN.PLATEAU.NumPlateauFour21D] = EmplRef_67_68_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour22D] = ((EmplRef_67_68_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour21] = EmplRef_67_68_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour22] = ((EmplRef_67_68_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_67_68_Var And &HFFFF&), ((EmplRef_67_68_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'73
Private Sub EmplRef_69_70_Var_ValueChange()

    Dim EmplRef_69_70_Var As Double
    EmplRef_69_70_Var = [PIERCAN.PLC.MW2500.MW2612]

    [PIERCAN.PLATEAU.NumPlateauFour23D] = EmplRef_69_70_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour24D] = ((EmplRef_69_70_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour23] = EmplRef_69_70_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour24] = ((EmplRef_69_70_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_69_70_Var And &HFFFF&), ((EmplRef_69_70_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'74
Private Sub EmplRef_71_72_Var_ValueChange()

    Dim EmplRef_71_72_Var As Double
    EmplRef_71_72_Var = [PIERCAN.PLC.MW2500.MW2614]

    [PIERCAN.PLATEAU.NumPlateauFour25D] = EmplRef_71_72_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour26D] = ((EmplRef_71_72_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour25] = EmplRef_71_72_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour26] = ((EmplRef_71_72_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_71_72_Var And &HFFFF&), ((EmplRef_71_72_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'75
Private Sub EmplRef_73_74_Var_ValueChange()

    Dim EmplRef_73_74_Var As Double
    EmplRef_73_74_Var = [PIERCAN.PLC.MW2500.MW2616]

    [PIERCAN.PLATEAU.NumPlateauFour27D] = EmplRef_73_74_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour28D] = ((EmplRef_73_74_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour27] = EmplRef_73_74_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour28] = ((EmplRef_73_74_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_73_74_Var And &HFFFF&), ((EmplRef_73_74_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'76
Private Sub EmplRef_75_76_Var_ValueChange()

    Dim EmplRef_75_76_Var As Double
    EmplRef_75_76_Var = [PIERCAN.PLC.MW2500.MW2618]

    [PIERCAN.PLATEAU.NumPlateauFour29D] = EmplRef_75_76_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour30D] = ((EmplRef_75_76_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour29] = EmplRef_75_76_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour30] = ((EmplRef_75_76_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_75_76_Var And &HFFFF&), ((EmplRef_75_76_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'77
Private Sub EmplRef_77_78_Var_ValueChange()

    Dim EmplRef_77_78_Var As Double
    EmplRef_77_78_Var = [PIERCAN.PLC.MW2500.MW2620]

    [PIERCAN.PLATEAU.NumPlateauFour31D] = EmplRef_77_78_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour32D] = ((EmplRef_77_78_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour31] = EmplRef_77_78_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour32] = ((EmplRef_77_78_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_77_78_Var And &HFFFF&), ((EmplRef_77_78_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'78
Private Sub EmplRef_79_80_Var_ValueChange()

    Dim EmplRef_79_80_Var As Double
    EmplRef_79_80_Var = [PIERCAN.PLC.MW2500.MW2622]

    [PIERCAN.PLATEAU.NumPlateauFour33D] = EmplRef_79_80_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour34D] = ((EmplRef_79_80_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour33] = EmplRef_79_80_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour34] = ((EmplRef_79_80_Var \ (2 ^ 16)) And &HFFFF&)
    
    'debut zone 2 CV1
    etat_plateau (EmplRef_79_80_Var And &HFFFF&), ((EmplRef_79_80_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Debut_chauffe_zone_2, type_equipement.Four, type_lieu.Four, 0, trac_ok_var

End Sub

'79
Private Sub EmplRef_81_82_Var_ValueChange()

    Dim EmplRef_81_82_Var As Double
    EmplRef_81_82_Var = [PIERCAN.PLC.MW2500.MW2624]

    [PIERCAN.PLATEAU.NumPlateauFour35D] = EmplRef_81_82_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour36D] = ((EmplRef_81_82_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour35] = EmplRef_81_82_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour36] = ((EmplRef_81_82_Var \ (2 ^ 16)) And &HFFFF&)
    
    'debut zone 2 CV2
    etat_plateau (EmplRef_81_82_Var And &HFFFF&), ((EmplRef_81_82_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Debut_chauffe_zone_2, type_equipement.PS, type_lieu.Four, 0, trac_ok_var

End Sub

'80
Private Sub EmplRef_83_84_Var_ValueChange()

    Dim EmplRef_83_84_Var As Double
    EmplRef_83_84_Var = [PIERCAN.PLC.MW2500.MW2626]

    [PIERCAN.PLATEAU.NumPlateauFour37D] = EmplRef_83_84_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour38D] = ((EmplRef_83_84_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour37] = EmplRef_83_84_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour38] = ((EmplRef_83_84_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_83_84_Var And &HFFFF&), ((EmplRef_83_84_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'81
Private Sub EmplRef_85_86_Var_ValueChange()

    Dim EmplRef_85_86_Var As Double
    EmplRef_85_86_Var = [PIERCAN.PLC.MW2500.MW2628]

    [PIERCAN.PLATEAU.NumPlateauFour39D] = EmplRef_85_86_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour40D] = ((EmplRef_85_86_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour39] = EmplRef_85_86_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour40] = ((EmplRef_85_86_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_85_86_Var And &HFFFF&), ((EmplRef_85_86_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'82
Private Sub EmplRef_87_88_Var_ValueChange()

    Dim EmplRef_87_88_Var As Double
    EmplRef_87_88_Var = [PIERCAN.PLC.MW2500.MW2630]

    [PIERCAN.PLATEAU.NumPlateauFour41D] = EmplRef_87_88_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour42D] = ((EmplRef_87_88_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour41] = EmplRef_87_88_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour42] = ((EmplRef_87_88_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_87_88_Var And &HFFFF&), ((EmplRef_87_88_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'83
Private Sub EmplRef_89_90_Var_ValueChange()

    Dim EmplRef_89_90_Var As Double
    EmplRef_89_90_Var = [PIERCAN.PLC.MW2500.MW2632]

    [PIERCAN.PLATEAU.NumPlateauFour43D] = EmplRef_89_90_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour44D] = ((EmplRef_89_90_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour43] = EmplRef_89_90_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour44] = ((EmplRef_89_90_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_89_90_Var And &HFFFF&), ((EmplRef_89_90_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'84
Private Sub EmplRef_91_92_Var_ValueChange()

    Dim EmplRef_91_92_Var As Double
    EmplRef_91_92_Var = [PIERCAN.PLC.MW2500.MW2634]

    [PIERCAN.PLATEAU.NumPlateauFour45D] = EmplRef_91_92_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour46D] = ((EmplRef_91_92_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour45] = EmplRef_91_92_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour46] = ((EmplRef_91_92_Var \ (2 ^ 16)) And &HFFFF&)
    
    'debut zone 3 CV1
    etat_plateau (EmplRef_91_92_Var And &HFFFF&), ((EmplRef_91_92_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Debut_chauffe_zone_3, type_equipement.PS, type_lieu.Four, 0, trac_ok_var

End Sub

'85
Private Sub EmplRef_93_94_Var_ValueChange()

    Dim EmplRef_93_94_Var As Double
    EmplRef_93_94_Var = [PIERCAN.PLC.MW2500.MW2636]

    [PIERCAN.PLATEAU.NumPlateauFour47D] = EmplRef_93_94_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour48D] = ((EmplRef_93_94_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour47] = EmplRef_93_94_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour48] = ((EmplRef_93_94_Var \ (2 ^ 16)) And &HFFFF&)
    
    'debut zone 3 CV2
    etat_plateau (EmplRef_93_94_Var And &HFFFF&), ((EmplRef_93_94_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Debut_chauffe_zone_3, type_equipement.PS, type_lieu.Four, 0, trac_ok_var
    

End Sub

'86
Private Sub EmplRef_95_96_Var_ValueChange()

    Dim EmplRef_95_96_Var As Double
    EmplRef_95_96_Var = [PIERCAN.PLC.MW2500.MW2638]

    [PIERCAN.PLATEAU.NumPlateauFour49D] = EmplRef_95_96_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour50D] = ((EmplRef_95_96_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour49] = EmplRef_95_96_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour50] = ((EmplRef_95_96_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_95_96_Var And &HFFFF&), ((EmplRef_95_96_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'87
Private Sub EmplRef_97_98_Var_ValueChange()

    Dim EmplRef_97_98_Var As Double
    EmplRef_97_98_Var = [PIERCAN.PLC.MW2500.MW2640]

    [PIERCAN.PLATEAU.NumPlateauFour51D] = EmplRef_97_98_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour52D] = ((EmplRef_97_98_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour51] = EmplRef_97_98_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour52] = ((EmplRef_97_98_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_97_98_Var And &HFFFF&), ((EmplRef_97_98_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'88
Private Sub EmplRef_99_100_Var_ValueChange()

    Dim EmplRef_99_100_Var As Double
    EmplRef_99_100_Var = [PIERCAN.PLC.MW2500.MW2642]

    [PIERCAN.PLATEAU.NumPlateauFour53D] = EmplRef_99_100_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour54D] = ((EmplRef_99_100_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour53] = EmplRef_99_100_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour54] = ((EmplRef_99_100_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_99_100_Var And &HFFFF&), ((EmplRef_99_100_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'89
Private Sub EmplRef_101_102_Var_ValueChange()

    Dim EmplRef_101_102_Var As Double
    EmplRef_101_102_Var = [PIERCAN.PLC.MW2500.MW2644]

    [PIERCAN.PLATEAU.NumPlateauFour55D] = EmplRef_101_102_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour56D] = ((EmplRef_101_102_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour55] = EmplRef_101_102_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour56] = ((EmplRef_101_102_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_101_102_Var And &HFFFF&), ((EmplRef_101_102_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'90
Private Sub EmplRef_103_104_Var_ValueChange()

    Dim EmplRef_103_104_Var As Double
    EmplRef_103_104_Var = [PIERCAN.PLC.MW2500.MW2646]

    [PIERCAN.PLATEAU.NumPlateauFour57D] = EmplRef_103_104_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour58D] = ((EmplRef_103_104_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour57] = EmplRef_103_104_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour58] = ((EmplRef_103_104_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_103_104_Var And &HFFFF&), ((EmplRef_103_104_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'91
Private Sub EmplRef_105_106_Var_ValueChange()

    Dim EmplRef_105_106_Var As Double
    EmplRef_105_106_Var = [PIERCAN.PLC.MW2500.MW2648]

    [PIERCAN.PLATEAU.NumPlateauFour59D] = EmplRef_105_106_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour60D] = ((EmplRef_105_106_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour59] = EmplRef_105_106_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour60] = ((EmplRef_105_106_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_105_106_Var And &HFFFF&), ((EmplRef_105_106_Var \ (2 ^ 16)) And &HFFFF&), "Dans le four", "Dans le four", type_evenement.PRODUCTION, type_operation.created_HMI, 0, type_equipement.PS, type_lieu.Four, type_lieu.Four, False

End Sub

'92
Private Sub EmplRef_107_108_Var_ValueChange()

    Dim EmplRef_107_108_Var As Double
    EmplRef_107_108_Var = [PIERCAN.PLC.MW2500.MW2650]

    [PIERCAN.PLATEAU.NumPlateauFour61D] = EmplRef_107_108_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour62D] = ((EmplRef_107_108_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour61] = EmplRef_107_108_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour62] = ((EmplRef_107_108_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_107_108_Var And &HFFFF&), ((EmplRef_107_108_Var \ (2 ^ 16)) And &HFFFF&), "Sortie du four", "Sortie du four", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Fin_chauffe, type_equipement.PS, type_lieu.Four, 0, trac_ok_var

    'si dernier plateau et bit OF valide par la supervision = OFF (TagSetBit "PIERCAN.PLC.MW2000.MW2036", 14 = ON) alors pop up aller valider la preparation
End Sub

'93
Private Sub EmplRef_109_110_Var_ValueChange()

    Dim EmplRef_109_110_Var As Double
    EmplRef_109_110_Var = [PIERCAN.PLC.MW2500.MW2652]

    [PIERCAN.PLATEAU.NumPlateauFour63D] = EmplRef_109_110_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour64D] = ((EmplRef_109_110_Var \ (2 ^ 16)) And &HFFFF&)
    [PIERCAN.PLATEAU.NumPlateauFour63] = EmplRef_109_110_Var And &HFFFF&
    [PIERCAN.PLATEAU.NumPlateauFour64] = ((EmplRef_109_110_Var \ (2 ^ 16)) And &HFFFF&)
    
    etat_plateau (EmplRef_109_110_Var And &HFFFF&), ((EmplRef_109_110_Var \ (2 ^ 16)) And &HFFFF&), "Sortie du four", "Sortie du four", type_evenement.PRODUCTION, type_operation.created_HMI, type_message.Fin_chauffe, type_equipement.PS, type_lieu.Four, 0, trac_ok_var

End Sub

'99
Private Sub Etat_R1_Var_ValueChange()
    Dim R1_Etat As Long
    R1_Etat = [PIERCAN.PLC.MW4000.MW4000]
    [PIERCAN.ROBOTS.R1.Etat_Connecte] = (R1_Etat And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_Teach] = (R1_Etat And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_Play] = (R1_Etat And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_Remote] = (R1_Etat And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_Running] = (R1_Etat And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_Hold] = (R1_Etat And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_Error] = (R1_Etat And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_alarm] = (R1_Etat And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_ServoOn] = (R1_Etat And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_JobEnCours] = (R1_Etat And (2 ^ 9)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_JobFini] = (R1_Etat And (2 ^ 10)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_JobArreteError] = (R1_Etat And (2 ^ 11)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_PeuxContinuer] = (R1_Etat And (2 ^ 12)) <> 0
    [PIERCAN.ROBOTS.R1.Etat_Dgt_Haut] = (R1_Etat And (2 ^ 13)) <> 0
    '[PIERCAN.ROBOTS.R1.Etat_reserve_bit_1] = (R1_Etat And (2 ^ 14)) <> 0
    '[PIERCAN.ROBOTS.R1.Etat_reserve_bit_2] = (R1_Etat And (2 ^ 15)) <> 0
End Sub


'100
Private Sub Etat_R2_Var_ValueChange()
    Dim R2_Etat As Long
    R2_Etat = [PIERCAN.PLC.MW4000.MW4002]
    [PIERCAN.ROBOTS.R2.Etat_Connecte] = (R2_Etat And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_Teach] = (R2_Etat And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_Play] = (R2_Etat And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_Remote] = (R2_Etat And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_Running] = (R2_Etat And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_Hold] = (R2_Etat And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_Error] = (R2_Etat And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_alarm] = (R2_Etat And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_ServoOn] = (R2_Etat And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_JobEnCours] = (R2_Etat And (2 ^ 9)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_JobFini] = (R2_Etat And (2 ^ 10)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_JobArreteError] = (R2_Etat And (2 ^ 11)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_PeuxContinuer] = (R2_Etat And (2 ^ 12)) <> 0
    [PIERCAN.ROBOTS.R2.Etat_Dgt_Haut] = (R2_Etat And (2 ^ 13)) <> 0
    '[PIERCAN.ROBOTS.R2.Etat_reserve_bit_1] = (R2_Etat And (2 ^ 14)) <> 0
    '[PIERCAN.ROBOTS.R2.Etat_reserve_bit_2] = (R2_Etat And (2 ^ 15)) <> 0
End Sub

'101
Private Sub Etat_R3_Var_ValueChange()
    Dim R3_Etat As Long
    R3_Etat = [PIERCAN.PLC.MW4000.MW4004]
    [PIERCAN.ROBOTS.R3.Etat_Connecte] = (R3_Etat And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_Teach] = (R3_Etat And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_Play] = (R3_Etat And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_Remote] = (R3_Etat And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_Running] = (R3_Etat And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_Hold] = (R3_Etat And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_Error] = (R3_Etat And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_alarm] = (R3_Etat And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_ServoOn] = (R3_Etat And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_JobEnCours] = (R3_Etat And (2 ^ 9)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_JobFini] = (R3_Etat And (2 ^ 10)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_JobArreteError] = (R3_Etat And (2 ^ 11)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_PeuxContinuer] = (R3_Etat And (2 ^ 12)) <> 0
    [PIERCAN.ROBOTS.R3.Etat_Dgt_Haut] = (R3_Etat And (2 ^ 13)) <> 0
    '[PIERCAN.ROBOTS.R3.Etat_reserve_bit_1] = (R3_Etat And (2 ^ 14)) <> 0
    '[PIERCAN.ROBOTS.R3.Etat_reserve_bit_2] = (R3_Etat And (2 ^ 15)) <> 0
End Sub

'102
Private Sub Etat_R4_Var_ValueChange()
    Dim R4_Etat As Long
    R4_Etat = [PIERCAN.PLC.MW4000.MW4006]
    [PIERCAN.ROBOTS.R4.Etat_Connecte] = (R4_Etat And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_Teach] = (R4_Etat And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_Play] = (R4_Etat And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_Remote] = (R4_Etat And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_Running] = (R4_Etat And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_Hold] = (R4_Etat And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_Error] = (R4_Etat And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_alarm] = (R4_Etat And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_ServoOn] = (R4_Etat And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_JobEnCours] = (R4_Etat And (2 ^ 9)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_JobFini] = (R4_Etat And (2 ^ 10)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_JobArreteError] = (R4_Etat And (2 ^ 11)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_PeuxContinuer] = (R4_Etat And (2 ^ 12)) <> 0
    [PIERCAN.ROBOTS.R4.Etat_Dgt_Haut] = (R4_Etat And (2 ^ 13)) <> 0
    '[PIERCAN.ROBOTS.R4.Etat_reserve_bit_1] = (R4_Etat And (2 ^ 14)) <> 0
    '[PIERCAN.ROBOTS.R4.Etat_reserve_bit_2] = (R4_Etat And (2 ^ 15)) <> 0
End Sub

'103
Private Sub Etat_R5_Var_ValueChange()
    Dim R5_Etat As Long
    R5_Etat = [PIERCAN.PLC.MW4000.MW4008]
    [PIERCAN.ROBOTS.R5.Etat_Connecte] = (R5_Etat And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_Teach] = (R5_Etat And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_Play] = (R5_Etat And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_Remote] = (R5_Etat And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_Running] = (R5_Etat And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_Hold] = (R5_Etat And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_Error] = (R5_Etat And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_alarm] = (R5_Etat And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_ServoOn] = (R5_Etat And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_JobEnCours] = (R5_Etat And (2 ^ 9)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_JobFini] = (R5_Etat And (2 ^ 10)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_JobArreteError] = (R5_Etat And (2 ^ 11)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_PeuxContinuer] = (R5_Etat And (2 ^ 12)) <> 0
    [PIERCAN.ROBOTS.R5.Etat_Dgt_Haut] = (R5_Etat And (2 ^ 13)) <> 0
    '[PIERCAN.ROBOTS.R5.Etat_reserve_bit_1] = (R5_Etat And (2 ^ 14)) <> 0
    '[PIERCAN.ROBOTS.R5.Etat_reserve_bit_2] = (R5_Etat And (2 ^ 15)) <> 0
End Sub

Private Sub plateau_fini_1_15_Var_ValueChange()

End Sub

Private Sub plateau_fini_16_31_Var_ValueChange()

End Sub

'104
Private Sub R1_Etat_prehenseur_Var_ValueChange()
    Dim R1_Etat_prehenseur As Long
    R1_Etat_prehenseur = [PIERCAN.PLC.MW4000.MW4010]
    [PIERCAN.ROBOTS.R1.PREHENSEUR.Etat_Magnetise_A] = (R1_Etat_prehenseur And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R1.PREHENSEUR.Etat_Demagnetise_A] = (R1_Etat_prehenseur And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R1.PREHENSEUR.Etat_pres_plaque_A] = (R1_Etat_prehenseur And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R1.CAMERA.Etat_CamA_Connecte] = (R1_Etat_prehenseur And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R1.CAMERA.Etat_CamA_Ctrl_EnCours] = (R1_Etat_prehenseur And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R1.CAMERA.Etat_CamA_Ctrl_NOk] = (R1_Etat_prehenseur And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R1.CAMERA.Etat_CamA_Ctrl_Ok] = (R1_Etat_prehenseur And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R1.CAMERA.Etat_CamA_Error] = (R1_Etat_prehenseur And (2 ^ 7)) <> 0
End Sub

'105
Private Sub R2_Etat_prehenseur_Var_ValueChange()
    Dim R2_Etat_prehenseur As Long
    R2_Etat_prehenseur = [PIERCAN.PLC.MW4000.MW4012]
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Etat_Magnetise_A] = (R2_Etat_prehenseur And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Etat_Demagnetise_A] = (R2_Etat_prehenseur And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Etat_pres_plaque_A] = (R2_Etat_prehenseur And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R2.CAMERA.Etat_CamA_Connecte] = (R2_Etat_prehenseur And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R2.CAMERA.Etat_CamA_Ctrl_EnCours] = (R2_Etat_prehenseur And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R2.CAMERA.Etat_CamA_Ctrl_NOk] = (R2_Etat_prehenseur And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R2.CAMERA.Etat_CamA_Ctrl_Ok] = (R2_Etat_prehenseur And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R2.CAMERA.Etat_CamA_Error] = (R2_Etat_prehenseur And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Etat_Magnetise_B] = (R2_Etat_prehenseur And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Etat_Demagnetise_B] = (R2_Etat_prehenseur And (2 ^ 9)) <> 0
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Etat_pres_plaque_B] = (R2_Etat_prehenseur And (2 ^ 10)) <> 0
End Sub

'106
Private Sub R3_Etat_prehenseur_Var_ValueChange()
    Dim R3_Etat_prehenseur As Long
    R3_Etat_prehenseur = [PIERCAN.PLC.MW4000.MW4014]
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Etat_Magnetise_A] = (R3_Etat_prehenseur And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Etat_Demagnetise_A] = (R3_Etat_prehenseur And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Etat_pres_plaque_A] = (R3_Etat_prehenseur And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R3.CAMERA.Etat_CamA_Connecte] = (R3_Etat_prehenseur And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R3.CAMERA.Etat_CamA_Ctrl_EnCours] = (R3_Etat_prehenseur And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R3.CAMERA.Etat_CamA_Ctrl_NOk] = (R3_Etat_prehenseur And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R3.CAMERA.Etat_CamA_Ctrl_Ok] = (R3_Etat_prehenseur And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R3.CAMERA.Etat_CamA_Error] = (R3_Etat_prehenseur And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Etat_Magnetise_B] = (R3_Etat_prehenseur And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Etat_Demagnetise_B] = (R3_Etat_prehenseur And (2 ^ 9)) <> 0
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Etat_pres_plaque_B] = (R3_Etat_prehenseur And (2 ^ 10)) <> 0
End Sub

'107
Private Sub R4_Etat_prehenseur_Var_ValueChange()
    Dim R4_Etat_prehenseur As Long
    R4_Etat_prehenseur = [PIERCAN.PLC.MW4000.MW4016]
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Etat_Magnetise_A] = (R4_Etat_prehenseur And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Etat_Demagnetise_A] = (R4_Etat_prehenseur And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Etat_pres_plaque_A] = (R4_Etat_prehenseur And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamA_Connecte] = (R4_Etat_prehenseur And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamA_Ctrl_EnCours] = (R4_Etat_prehenseur And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamA_Ctrl_NOk] = (R4_Etat_prehenseur And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamA_Ctrl_Ok] = (R4_Etat_prehenseur And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamA_Error] = (R4_Etat_prehenseur And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Etat_Magnetise_B] = (R4_Etat_prehenseur And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Etat_Demagnetise_B] = (R4_Etat_prehenseur And (2 ^ 9)) <> 0
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Etat_pres_plaque_B] = (R4_Etat_prehenseur And (2 ^ 10)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamB_Connecte] = (R4_Etat_prehenseur And (2 ^ 11)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamB_Ctrl_EnCours] = (R4_Etat_prehenseur And (2 ^ 12)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamB_Ctrl_NOk] = (R4_Etat_prehenseur And (2 ^ 13)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamB_Ctrl_Ok] = (R4_Etat_prehenseur And (2 ^ 14)) <> 0
    [PIERCAN.ROBOTS.R4.CAMERA.Etat_CamB_Error] = (R4_Etat_prehenseur And (2 ^ 15)) <> 0
End Sub

'108
Private Sub R5_Etat_prehenseur_Var_ValueChange()
    Dim R5_Etat_prehenseur As Long
    R5_Etat_prehenseur = [PIERCAN.PLC.MW4000.MW4018]
    [PIERCAN.ROBOTS.R5.PREHENSEUR.Etat_Magnetise_A] = (R5_Etat_prehenseur And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R5.PREHENSEUR.Etat_Demagnetise_A] = (R5_Etat_prehenseur And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R5.PREHENSEUR.Etat_pres_plaque_A] = (R5_Etat_prehenseur And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R5.CAMERA.Etat_CamA_Connecte] = (R5_Etat_prehenseur And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R5.CAMERA.Etat_CamA_Ctrl_EnCours] = (R5_Etat_prehenseur And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R5.CAMERA.Etat_CamA_Ctrl_NOk] = (R5_Etat_prehenseur And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R5.CAMERA.Etat_CamA_Ctrl_Ok] = (R5_Etat_prehenseur And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R5.CAMERA.Etat_CamA_Error] = (R5_Etat_prehenseur And (2 ^ 7)) <> 0
End Sub

'109
Private Sub Cmd_R1_Var_ValueChange()
    Dim R1_Cmd As Long
    R1_Cmd = [PIERCAN.PLC.MW4500.MW4500]
    [PIERCAN.ROBOTS.R1.Cmd_Eve_ServoOn] = (R1_Cmd And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R1.Cmd_Eve_ServoOff] = (R1_Cmd And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R1.Cmd_Eve_AckDefault] = (R1_Cmd And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R1.Cmd_Eve_StartJob] = (R1_Cmd And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R1.Cmd_Eve_StopJob] = (R1_Cmd And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R1.Cmd_Eve_ContinueJob] = (R1_Cmd And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R1.PREHENSEUR.Cmd_Eve_Magnetiser_A] = (R1_Cmd And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R1.PREHENSEUR.Cmd_Eve_Demagnetiser_A] = (R1_Cmd And (2 ^ 7)) <> 0
End Sub

'110
Private Sub Cmd_R2_Var_ValueChange()
    Dim R2_Cmd As Long
    R2_Cmd = [PIERCAN.PLC.MW4500.MW4502]
    [PIERCAN.ROBOTS.R2.Cmd_Eve_ServoOn] = (R2_Cmd And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R2.Cmd_Eve_ServoOff] = (R2_Cmd And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R2.Cmd_Eve_AckDefault] = (R2_Cmd And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R2.Cmd_Eve_StartJob] = (R2_Cmd And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R2.Cmd_Eve_StopJob] = (R2_Cmd And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R2.Cmd_Eve_ContinueJob] = (R2_Cmd And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Cmd_Eve_Magnetiser_A] = (R2_Cmd And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Cmd_Eve_Demagnetiser_A] = (R2_Cmd And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Cmd_Eve_Magnetiser_B] = (R2_Cmd And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R2.PREHENSEUR.Cmd_Eve_Demagnetiser_B] = (R2_Cmd And (2 ^ 9)) <> 0
End Sub

'111
Private Sub Cmd_R3_Var_ValueChange()
    Dim R3_Cmd As Long
    R3_Cmd = [PIERCAN.PLC.MW4500.MW4504]
    [PIERCAN.ROBOTS.R3.Cmd_Eve_ServoOn] = (R3_Cmd And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R3.Cmd_Eve_ServoOff] = (R3_Cmd And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R3.Cmd_Eve_AckDefault] = (R3_Cmd And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R3.Cmd_Eve_StartJob] = (R3_Cmd And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R3.Cmd_Eve_StopJob] = (R3_Cmd And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R3.Cmd_Eve_ContinueJob] = (R3_Cmd And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Cmd_Eve_Magnetiser_A] = (R3_Cmd And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Cmd_Eve_Demagnetiser_A] = (R3_Cmd And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Cmd_Eve_Magnetiser_B] = (R3_Cmd And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R3.PREHENSEUR.Cmd_Eve_Demagnetiser_B] = (R3_Cmd And (2 ^ 9)) <> 0
End Sub

'112
Private Sub Cmd_R4_Var_ValueChange()
    Dim R4_Cmd As Long
    R4_Cmd = [PIERCAN.PLC.MW4500.MW4506]
    [PIERCAN.ROBOTS.R4.Cmd_Eve_ServoOn] = (R4_Cmd And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R4.Cmd_Eve_ServoOff] = (R4_Cmd And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R4.Cmd_Eve_AckDefault] = (R4_Cmd And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R4.Cmd_Eve_StartJob] = (R4_Cmd And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R4.Cmd_Eve_StopJob] = (R4_Cmd And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R4.Cmd_Eve_ContinueJob] = (R4_Cmd And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Cmd_Eve_Magnetiser_A] = (R4_Cmd And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Cmd_Eve_Demagnetiser_A] = (R4_Cmd And (2 ^ 7)) <> 0
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Cmd_Eve_Magnetiser_B] = (R4_Cmd And (2 ^ 8)) <> 0
    [PIERCAN.ROBOTS.R4.PREHENSEUR.Cmd_Eve_Demagnetiser_B] = (R4_Cmd And (2 ^ 9)) <> 0
End Sub


'113
Private Sub Cmd_R5_Var_ValueChange()
    Dim R5_Cmd As Long
    R5_Cmd = [PIERCAN.PLC.MW4500.MW4508]
    [PIERCAN.ROBOTS.R5.Cmd_Eve_ServoOn] = (R5_Cmd And (2 ^ 0)) <> 0
    [PIERCAN.ROBOTS.R5.Cmd_Eve_ServoOff] = (R5_Cmd And (2 ^ 1)) <> 0
    [PIERCAN.ROBOTS.R5.Cmd_Eve_AckDefault] = (R5_Cmd And (2 ^ 2)) <> 0
    [PIERCAN.ROBOTS.R5.Cmd_Eve_StartJob] = (R5_Cmd And (2 ^ 3)) <> 0
    [PIERCAN.ROBOTS.R5.Cmd_Eve_StopJob] = (R5_Cmd And (2 ^ 4)) <> 0
    [PIERCAN.ROBOTS.R5.Cmd_Eve_ContinueJob] = (R5_Cmd And (2 ^ 5)) <> 0
    [PIERCAN.ROBOTS.R5.PREHENSEUR.Cmd_Eve_Magnetiser_A] = (R5_Cmd And (2 ^ 6)) <> 0
    [PIERCAN.ROBOTS.R5.PREHENSEUR.Cmd_Eve_Demagnetiser_A] = (R5_Cmd And (2 ^ 7)) <> 0
End Sub



'155
Private Sub API_Pcvue_echange_1_Var_ValueChange()
    Dim API_Pcvue_echange_1 As Long
    API_Pcvue_echange_1 = [PIERCAN.PLC.MW2500.MW2664]
    [PIERCAN.CYCLE.Api_recu_inibition_plateau] = (API_Pcvue_echange_1 And (2 ^ 0)) <> 0
    [PIERCAN.CYCLE.AUTO] = (API_Pcvue_echange_1 And (2 ^ 1)) <> 0
    [PIERCAN.CYCLE.MANU] = (API_Pcvue_echange_1 And (2 ^ 2)) <> 0
    [PIERCAN.CYCLE.En_Cycle] = (API_Pcvue_echange_1 And (2 ^ 3)) <> 0
    [PIERCAN.CYCLE.En_AFCY] = (API_Pcvue_echange_1 And (2 ^ 4)) <> 0
    [PIERCAN.CYCLE.E4_ok] = (API_Pcvue_echange_1 And (2 ^ 5)) <> 0
    [PIERCAN.CYCLE.Api_recu_Num_plateau] = (API_Pcvue_echange_1 And (2 ^ 6)) <> 0
    [PIERCAN.CYCLE.Api_Ethernet_Run] = (API_Pcvue_echange_1 And (2 ^ 7)) <> 0
    [PIERCAN.CYCLE.Api_E4_init_en_cours] = (API_Pcvue_echange_1 And (2 ^ 8)) <> 0
    [PIERCAN.CYCLE.Api_E4_init_OK] = (API_Pcvue_echange_1 And (2 ^ 9)) <> 0
    '[PIERCAN.E4_Def_General] = (API_Pcvue_echange_1 And (2 ^ 10)) <> 0
    [PIERCAN.CYCLE.Chargement_en_cours] = (API_Pcvue_echange_1 And (2 ^ 11)) <> 0
    '[PIERCAN.CDT.echange_robot] = (API_Pcvue_echange_1 And (2 ^ 12)) <> 0
    [PIERCAN.FOUR.mode2Convoyeur] = (API_Pcvue_echange_1 And (2 ^ 13)) <> 0
    [PIERCAN.FOUR.modeCV1_CV2] = (API_Pcvue_echange_1 And (2 ^ 14)) <> 0 'CV1 = 0 CV2 =1

    DoEvents
    
    Debug.Print ("Api_recu_Num_plateau: " & [PIERCAN.CYCLE.Api_recu_Num_plateau])
    
    
    If ([PIERCAN.CYCLE.Api_recu_Num_plateau] = True) Or ([PIERCAN.CYCLE.Api_recu_Num_plateau] = 1) Then
        TagResetBit "PIERCAN.PLC.MW2000.MW2036", 6 'valider  la renumerotation des  plateau sur la supervision vers l'automate

        Debug.Print ("Envoi reussi")
    End If
End Sub

'157
Private Sub PP_four_Var_ValueChange()
    Dim PP_four As Long
    PT_four = [PIERCAN.PLC.MW5000.MW5000]
    [PIERCAN.FOUR.PP_1A] = (PT_four And (2 ^ 0)) <> 0
    [PIERCAN.FOUR.PP_1B] = (PT_four And (2 ^ 1)) <> 0
    [PIERCAN.FOUR.PP_1C] = (PT_four And (2 ^ 2)) <> 0
    [PIERCAN.FOUR.PP_1D] = (PT_four And (2 ^ 3)) <> 0
    [PIERCAN.FOUR.PP_16A] = (PT_four And (2 ^ 4)) <> 0
    [PIERCAN.FOUR.PP_16B] = (PT_four And (2 ^ 5)) <> 0
    [PIERCAN.FOUR.PP_16C] = (PT_four And (2 ^ 6)) <> 0
    [PIERCAN.FOUR.PP_16D] = (PT_four And (2 ^ 7)) <> 0
    [PIERCAN.FOUR.ZS1_Marche] = (PT_four And (2 ^ 8)) <> 0
    [PIERCAN.FOUR.ZS2_Marche] = (PT_four And (2 ^ 9)) <> 0
    [PIERCAN.FOUR.ZV1_Marche] = (PT_four And (2 ^ 10)) <> 0
    [PIERCAN.FOUR.ZV2_Marche] = (PT_four And (2 ^ 11)) <> 0
    [PIERCAN.FOUR.CV1_Marche] = (PT_four And (2 ^ 12)) <> 0
    [PIERCAN.FOUR.CV2_Marche] = (PT_four And (2 ^ 13)) <> 0
End Sub


'158
Private Sub PT_four_Var_ValueChange()
    Dim PT_four As Long
    PT_four = [PIERCAN.PLC.MW5000.MW5002]
    [PIERCAN.FOUR.S1PT_Ouv] = (PT_four And (2 ^ 0)) <> 0
    [PIERCAN.FOUR.S2PT_Ferm] = (PT_four And (2 ^ 1)) <> 0
    [PIERCAN.FOUR.S3PT_Ouv] = (PT_four And (2 ^ 2)) <> 0
    [PIERCAN.FOUR.S4PT_Ferm] = (PT_four And (2 ^ 3)) <> 0
    [PIERCAN.FOUR.S5PT_Ouv] = (PT_four And (2 ^ 4)) <> 0
    [PIERCAN.FOUR.S6PT_Ferm] = (PT_four And (2 ^ 5)) <> 0
    [PIERCAN.FOUR.S7PT_Ouv] = (PT_four And (2 ^ 6)) <> 0
    [PIERCAN.FOUR.S8PT_Ferm] = (PT_four And (2 ^ 7)) <> 0
    [PIERCAN.FOUR.S9PT_Ouv] = (PT_four And (2 ^ 8)) <> 0
    [PIERCAN.FOUR.S10PT_Ferm] = (PT_four And (2 ^ 9)) <> 0
    [PIERCAN.FOUR.S11PT_Ouv] = (PT_four And (2 ^ 10)) <> 0
    [PIERCAN.FOUR.S12PT_Ferm] = (PT_four And (2 ^ 11)) <> 0
    [PIERCAN.FOUR.S13PT_Ouv] = (PT_four And (2 ^ 12)) <> 0
    [PIERCAN.FOUR.S14PT_Ferm] = (PT_four And (2 ^ 13)) <> 0
    [PIERCAN.FOUR.S15PT_Ouv] = (PT_four And (2 ^ 14)) <> 0
    [PIERCAN.FOUR.S16PT_Ferm] = (PT_four And (2 ^ 15)) <> 0
End Sub

Private Sub info_four_Var_ValueChange()
    Dim info_four As Long
    info_four = [PIERCAN.PLC.MW5000.MW5004]
    [PIERCAN.FOUR.AU] = (info_four And (2 ^ 0)) <> 0
    [PIERCAN.FOUR.Auto] = (info_four And (2 ^ 1)) <> 0
    [PIERCAN.FOUR.Temp_Atteinte] = (info_four And (2 ^ 2)) <> 0
    [PIERCAN.FOUR.Default] = (info_four And (2 ^ 3)) <> 0
    [PIERCAN.FOUR.CV1_pret] = (info_four And (2 ^ 4)) <> 0
    [PIERCAN.FOUR.CV2_pret] = (info_four And (2 ^ 5)) <> 0
    [PIERCAN.FOUR.220V_OK] = (info_four And (2 ^ 6)) <> 0
    [PIERCAN.FOUR.test_com] = (info_four And (2 ^ 7)) <> 0
    [PIERCAN.FOUR.chauffe_demarre] = (info_four And (2 ^ 8)) <> 0
    [PIERCAN.FOUR.four_post_ventille] = (info_four And (2 ^ 9)) <> 0
    '[PIERCAN.FOUR.S11PT_Ouv] = (info_four And (2 ^ 10)) <> 0
    '[PIERCAN.FOUR.S12PT_Ferm] = (info_four And (2 ^ 11)) <> 0
    '[PIERCAN.FOUR.S13PT_Ouv] = (info_four And (2 ^ 12)) <> 0
    '[PIERCAN.FOUR.S14PT_Ferm] = (info_four And (2 ^ 13)) <> 0
    '[PIERCAN.FOUR.S15PT_Ouv] = (info_four And (2 ^ 14)) <> 0
    '[PIERCAN.FOUR.S16PT_Ferm] = (info_four And (2 ^ 15)) <> 0
End Sub

'159
Private Sub etat_global_four_Var_ValueChange()
    Dim etat_global_four As Long
    etat_global_four = [PIERCAN.PLC.MW2500.MW2694]
    [PIERCAN.FOUR.220V_OK] = (etat_global_four And (2 ^ 0)) <> 0
    [PIERCAN.FOUR.AU] = (etat_global_four And (2 ^ 1)) <> 0
    [PIERCAN.FOUR.Auto] = (etat_global_four And (2 ^ 2)) <> 0
    [PIERCAN.FOUR.CV1_pret] = (etat_global_four And (2 ^ 3)) <> 0
    [PIERCAN.FOUR.CV2_pret] = (etat_global_four And (2 ^ 4)) <> 0
    [PIERCAN.FOUR.Default] = (etat_global_four And (2 ^ 5)) <> 0
    [PIERCAN.FOUR.Temp_Atteinte] = (etat_global_four And (2 ^ 6)) <> 0
    [PIERCAN.FOUR.E4_ACCES] = (etat_global_four And (2 ^ 7)) <> 0
    '[] = (etat_global_four And (2 ^ 8)) <> 0
    [PIERCAN.FOUR.Autor_CV1] = (etat_global_four And (2 ^ 9)) <> 0
    [PIERCAN.FOUR.Autor_CV2] = (etat_global_four And (2 ^ 10)) <> 0
    [PIERCAN.POSAGE.PSRINC2.en_chauffe] = (etat_global_four And (2 ^ 11)) <> 0
    [PIERCAN.POSAGE.PSCOAG.en_chauffe] = (etat_global_four And (2 ^ 12)) <> 0
    [PIERCAN.FOUR_PRE.en_chauffe] = (etat_global_four And (2 ^ 13)) <> 0
End Sub

Private Sub capteur_FPS_Var_ValueChange()
    Dim capteur_FPS As Long
    capteur_FPS = [PIERCAN.PLC.MW2500.MW2666]
    [PIERCAN.FOUR_PRE.Presence_Plaque_Entre] = (capteur_FPS And (2 ^ 0)) <> 0
    [PIERCAN.FOUR_PRE.Presence_Plaque_Sortie] = (capteur_FPS And (2 ^ 1)) <> 0
    [PIERCAN.FOUR_PRE.Porte_Ouverte_Entre] = (capteur_FPS And (2 ^ 2)) <> 0
    [PIERCAN.FOUR_PRE.Porte_Ferme_Entre] = (capteur_FPS And (2 ^ 3)) <> 0
    [PIERCAN.FOUR_PRE.Porte_Ouverte_Sortie] = (capteur_FPS And (2 ^ 4)) <> 0
    [PIERCAN.FOUR_PRE.Porte_Ferme_Sortie] = (capteur_FPS And (2 ^ 5)) <> 0
    [PIERCAN.FOUR_PRE.Convoyeur_En_Mouvement] = (capteur_FPS And (2 ^ 6)) <> 0
End Sub

'========================================================================
'msg erreur
'========================================================================
Private Sub msg_erreur_1_16_Var_ValueChange()
    Dim msg_erreur_1_16 As Long
    msg_erreur_1_16 = [PIERCAN.PLC.MW2500.MW2686]
    [PIERCAN.MESSAGES.mess_001] = (msg_erreur_1_16 And (2 ^ 0)) <> 0
    [PIERCAN.MESSAGES.mess_002] = (msg_erreur_1_16 And (2 ^ 1)) <> 0
    [PIERCAN.MESSAGES.mess_003] = (msg_erreur_1_16 And (2 ^ 2)) <> 0
    [PIERCAN.MESSAGES.mess_004] = (msg_erreur_1_16 And (2 ^ 3)) <> 0
    [PIERCAN.MESSAGES.mess_005] = (msg_erreur_1_16 And (2 ^ 4)) <> 0
    [PIERCAN.MESSAGES.mess_006] = (msg_erreur_1_16 And (2 ^ 5)) <> 0
    [PIERCAN.MESSAGES.mess_007] = (msg_erreur_1_16 And (2 ^ 6)) <> 0
    [PIERCAN.MESSAGES.mess_008] = (msg_erreur_1_16 And (2 ^ 7)) <> 0
    [PIERCAN.MESSAGES.mess_009] = (msg_erreur_1_16 And (2 ^ 8)) <> 0
    [PIERCAN.MESSAGES.mess_010] = (msg_erreur_1_16 And (2 ^ 9)) <> 0
    [PIERCAN.MESSAGES.mess_011] = (msg_erreur_1_16 And (2 ^ 10)) <> 0
    [PIERCAN.MESSAGES.mess_012] = (msg_erreur_1_16 And (2 ^ 11)) <> 0
    [PIERCAN.MESSAGES.mess_013] = (msg_erreur_1_16 And (2 ^ 12)) <> 0
    [PIERCAN.MESSAGES.mess_014] = (msg_erreur_1_16 And (2 ^ 13)) <> 0
    [PIERCAN.MESSAGES.mess_015] = (msg_erreur_1_16 And (2 ^ 14)) <> 0
    [PIERCAN.MESSAGES.mess_016] = (msg_erreur_1_16 And (2 ^ 15)) <> 0
End Sub

Private Sub msg_erreur_17_32_Var_ValueChange()
    Dim msg_erreur_17_32 As Long
    msg_erreur_17_32 = [PIERCAN.PLC.MW2500.MW2688]
    [PIERCAN.MESSAGES.mess_017] = (msg_erreur_17_32 And (2 ^ 0)) <> 0
    [PIERCAN.MESSAGES.mess_018] = (msg_erreur_17_32 And (2 ^ 1)) <> 0
    [PIERCAN.MESSAGES.mess_019] = (msg_erreur_17_32 And (2 ^ 2)) <> 0
    [PIERCAN.MESSAGES.mess_020] = (msg_erreur_17_32 And (2 ^ 3)) <> 0
    [PIERCAN.MESSAGES.mess_021] = (msg_erreur_17_32 And (2 ^ 4)) <> 0
    [PIERCAN.MESSAGES.mess_022] = (msg_erreur_17_32 And (2 ^ 5)) <> 0
    [PIERCAN.MESSAGES.mess_023] = (msg_erreur_17_32 And (2 ^ 6)) <> 0
    [PIERCAN.MESSAGES.mess_024] = (msg_erreur_17_32 And (2 ^ 7)) <> 0
    [PIERCAN.MESSAGES.mess_025] = (msg_erreur_17_32 And (2 ^ 8)) <> 0
    [PIERCAN.MESSAGES.mess_026] = (msg_erreur_17_32 And (2 ^ 9)) <> 0
    [PIERCAN.MESSAGES.mess_027] = (msg_erreur_17_32 And (2 ^ 10)) <> 0
    [PIERCAN.MESSAGES.mess_028] = (msg_erreur_17_32 And (2 ^ 11)) <> 0
    [PIERCAN.MESSAGES.mess_029] = (msg_erreur_17_32 And (2 ^ 12)) <> 0
    [PIERCAN.MESSAGES.mess_030] = (msg_erreur_17_32 And (2 ^ 13)) <> 0
    [PIERCAN.MESSAGES.mess_031] = (msg_erreur_17_32 And (2 ^ 14)) <> 0
    [PIERCAN.MESSAGES.mess_032] = (msg_erreur_17_32 And (2 ^ 15)) <> 0
End Sub

Private Sub msg_erreur_33_48_Var_ValueChange()
    Dim msg_erreur_33_48 As Long
    msg_erreur_33_48 = [PIERCAN.PLC.MW2500.MW2690]
    [PIERCAN.MESSAGES.mess_033] = (msg_erreur_33_48 And (2 ^ 0)) <> 0
    [PIERCAN.MESSAGES.mess_034] = (msg_erreur_33_48 And (2 ^ 1)) <> 0
    [PIERCAN.MESSAGES.mess_035] = (msg_erreur_33_48 And (2 ^ 2)) <> 0
    [PIERCAN.MESSAGES.mess_036] = (msg_erreur_33_48 And (2 ^ 3)) <> 0
    [PIERCAN.MESSAGES.mess_037] = (msg_erreur_33_48 And (2 ^ 4)) <> 0
    [PIERCAN.MESSAGES.mess_038] = (msg_erreur_33_48 And (2 ^ 5)) <> 0
    [PIERCAN.MESSAGES.mess_039] = (msg_erreur_33_48 And (2 ^ 6)) <> 0
    [PIERCAN.MESSAGES.mess_040] = (msg_erreur_33_48 And (2 ^ 7)) <> 0
    [PIERCAN.MESSAGES.mess_041] = (msg_erreur_33_48 And (2 ^ 8)) <> 0
    [PIERCAN.MESSAGES.mess_042] = (msg_erreur_33_48 And (2 ^ 9)) <> 0
    [PIERCAN.MESSAGES.mess_043] = (msg_erreur_33_48 And (2 ^ 10)) <> 0
    [PIERCAN.MESSAGES.mess_044] = (msg_erreur_33_48 And (2 ^ 11)) <> 0
    [PIERCAN.MESSAGES.mess_045] = (msg_erreur_33_48 And (2 ^ 12)) <> 0
    [PIERCAN.MESSAGES.mess_046] = (msg_erreur_33_48 And (2 ^ 13)) <> 0
    [PIERCAN.MESSAGES.mess_047] = (msg_erreur_33_48 And (2 ^ 14)) <> 0
    [PIERCAN.MESSAGES.mess_048] = (msg_erreur_33_48 And (2 ^ 15)) <> 0
End Sub

Private Sub msg_erreur_49_64_Var_ValueChange()
    Dim msg_erreur_49_64 As Long
    msg_erreur_49_64 = [PIERCAN.PLC.MW2500.MW2692]
    [PIERCAN.MESSAGES.mess_049] = (msg_erreur_49_64 And (2 ^ 0)) <> 0
    [PIERCAN.MESSAGES.mess_050] = (msg_erreur_49_64 And (2 ^ 1)) <> 0
    [PIERCAN.MESSAGES.mess_051] = (msg_erreur_49_64 And (2 ^ 2)) <> 0
    [PIERCAN.MESSAGES.mess_052] = (msg_erreur_49_64 And (2 ^ 3)) <> 0
    [PIERCAN.MESSAGES.mess_053] = (msg_erreur_49_64 And (2 ^ 4)) <> 0
    [PIERCAN.MESSAGES.mess_054] = (msg_erreur_49_64 And (2 ^ 5)) <> 0
    [PIERCAN.MESSAGES.mess_055] = (msg_erreur_49_64 And (2 ^ 6)) <> 0
    [PIERCAN.MESSAGES.mess_056] = (msg_erreur_49_64 And (2 ^ 7)) <> 0
    [PIERCAN.MESSAGES.mess_057] = (msg_erreur_49_64 And (2 ^ 8)) <> 0
    [PIERCAN.MESSAGES.mess_058] = (msg_erreur_49_64 And (2 ^ 9)) <> 0
    [PIERCAN.MESSAGES.mess_059] = (msg_erreur_49_64 And (2 ^ 10)) <> 0
    [PIERCAN.MESSAGES.mess_060] = (msg_erreur_49_64 And (2 ^ 11)) <> 0
    [PIERCAN.MESSAGES.mess_061] = (msg_erreur_49_64 And (2 ^ 12)) <> 0
    [PIERCAN.MESSAGES.mess_062] = (msg_erreur_49_64 And (2 ^ 13)) <> 0
    [PIERCAN.MESSAGES.mess_063] = (msg_erreur_49_64 And (2 ^ 14)) <> 0
    '[PIERCAN.MESSAGES.mess_064] = (msg_erreur_49_64 And (2 ^ 15)) <> 0
End Sub

'========================================================================
'secu
'========================================================================
Private Sub secu1_Var_ValueChange()
    Dim secu1 As Long
    secu1 = [PIERCAN.PLC.MW10100.MW10170]
    
    [PIERCAN.SECU.KAU1] = (secu1 And (2 ^ 0)) <> 0
    [PIERCAN.SECU.R1_OK] = (secu1 And (2 ^ 1)) <> 0
    [PIERCAN.SECU.R2_OK] = (secu1 And (2 ^ 2)) <> 0
    [PIERCAN.SECU.R3_OK] = (secu1 And (2 ^ 3)) <> 0
    [PIERCAN.SECU.R4_OK] = (secu1 And (2 ^ 4)) <> 0
    [PIERCAN.SECU.R5_OK] = (secu1 And (2 ^ 5)) <> 0
    [PIERCAN.SECU.ZONE_PROCESS_OK] = (secu1 And (2 ^ 6)) <> 0
    [PIERCAN.SECU.FOUR_MOUV_OK] = (secu1 And (2 ^ 7)) <> 0
    
    [PIERCAN.SECU.Z_DEMOU_OK] = (secu1 And (2 ^ 8)) <> 0
    [PIERCAN.SECU.Z_TALC_OK] = (secu1 And (2 ^ 9)) <> 0
    [PIERCAN.SECU.Z_1_OK] = (secu1 And (2 ^ 10)) <> 0
    [PIERCAN.SECU.Z_2_OK] = (secu1 And (2 ^ 11)) <> 0
    [PIERCAN.SECU.Z_3_OK] = (secu1 And (2 ^ 12)) <> 0
    [PIERCAN.SECU.Z_4_OK] = (secu1 And (2 ^ 13)) <> 0
    [PIERCAN.SECU.Z_PNC_OK] = (secu1 And (2 ^ 14)) <> 0
    [PIERCAN.SECU.Z_PFINE_OK] = (secu1 And (2 ^ 15)) <> 0
    
End Sub


Private Sub secu2_Var_ValueChange()
    Dim secu2 As Double
    secu2 = [PIERCAN.PLC.MW10100.MW10172]
    
    [PIERCAN.SECU.RADAR_DEMOULAGE] = (secu2 And (2 ^ 0)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 1)) <> 0
    [PIERCAN.SECU.PORTE_DEMOULAGE] = (secu2 And (2 ^ 2)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 3)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 4)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 5)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 6)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 7)) <> 0
    
    [PIERCAN.SECU.PORTE_TALC] = (secu2 And (2 ^ 8)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 9)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 10)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 11)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 12)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 13)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 14)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 15)) <> 0
 
    
End Sub

Private Sub secu3_Var_ValueChange()
    Dim secu3 As Long
    secu3 = [PIERCAN.PLC.MW10100.MW10173]
    
    [PIERCAN.SECU.BI_ZONE1_OPE] = (secu3 And (2 ^ 0)) <> 0
    '[PIERCAN.SECU.R1_OK] = (secu3 And (2 ^ 1)) <> 0
    [PIERCAN.SECU.BI_ZONE1_PRO] = (secu3 And (2 ^ 2)) <> 0
    '[PIERCAN.SECU.R3_OK] = (secu3 And (2 ^ 3)) <> 0
    '[PIERCAN.SECU.R4_OK] = (secu3 And (2 ^ 4)) <> 0
    '[PIERCAN.SECU.R5_OK] = (secu3 And (2 ^ 5)) <> 0
    '[PIERCAN.SECU.FOUR_MOUV_OK] = (secu3 And (2 ^ 6)) <> 0
    '[PIERCAN.SECU.ZONE_PROCESS_OK] = (secu3 And (2 ^ 7)) <> 0
    [PIERCAN.SECU.BI_ZONE2_OPE] = (secu3 And (2 ^ 8)) <> 0
    '[PIERCAN.SECU.Z_TALC_OK] = (secu3 And (2 ^ 9)) <> 0
    [PIERCAN.SECU.BI_ZONE2_PRO] = (secu3 And (2 ^ 10)) <> 0
    '[PIERCAN.SECU.Z_2_OK] = (secu3 And (2 ^ 11)) <> 0
    [PIERCAN.SECU.BI_ZONE3_OPE] = (secu3 And (2 ^ 12)) <> 0
    '[PIERCAN.SECU.Z_4_OK] = (secu3 And (2 ^ 13)) <> 0
    [PIERCAN.SECU.BI_ZONE3_PRO] = (secu3 And (2 ^ 14)) <> 0
    '[PIERCAN.SECU.Z_PFINE_OK] = (secu3 And (2 ^ 15)) <> 0

  
End Sub

Private Sub secu4_Var_ValueChange()
    Dim secu4 As Long
    secu4 = [PIERCAN.PLC.MW10100.MW10174]
    
    [PIERCAN.SECU.BI_ZONE4_OPE] = (secu4 And (2 ^ 0)) <> 0
    '[PIERCAN.SECU.R1_OK] = (secu4 And (2 ^ 1)) <> 0
    [PIERCAN.SECU.BI_ZONE4_PRO] = (secu4 And (2 ^ 2)) <> 0
    '[PIERCAN.SECU.R3_OK] = (secu4 And (2 ^ 3)) <> 0
    [PIERCAN.SECU.KAU_PORTE_MAINTENANCE] = (secu4 And (2 ^ 4)) <> 0
    
    [PIERCAN.SECU.KAU_ARMOIRE_PRO] = (secu4 And (2 ^ 8)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 9)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 10)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 11)) <> 0
    [PIERCAN.SECU.KAU_FOUR_VULC] = (secu4 And (2 ^ 12)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 13)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 14)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu2 And (2 ^ 15)) <> 0
 
  
End Sub

Private Sub secu5_Var_ValueChange()
    Dim secu5 As Long
    secu5 = [PIERCAN.PLC.MW10100.MW10175]
    
    [PIERCAN.SECU.PORTE_MAINTENANCE] = (secu5 And (2 ^ 0)) <> 0
    '[PIERCAN.SECU.BI_ZONE_4_OPE] = (secu5 And (2 ^ 1)) <> 0
    '[PIERCAN.SECU.BI_ZONE_4_PROCESS] = (secu5 And (2 ^ 2)) <> 0
    '[PIERCAN.SECU.R3_OK] = (secu5 And (2 ^ 3)) <> 0
    
    [PIERCAN.SECU.BI_ZONE_PNC_OPE] = (secu5 And (2 ^ 8)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu5 And (2 ^ 9)) <> 0
    [PIERCAN.SECU.BI_ZONE_PNC_PRO] = (secu5 And (2 ^ 10)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu5 And (2 ^ 11)) <> 0
    [PIERCAN.SECU.BI_ZONE_PPF_OPE] = (secu5 And (2 ^ 12)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu5 And (2 ^ 13)) <> 0
    [PIERCAN.SECU.BI_ZONE_PPF_PRO] = (secu5 And (2 ^ 14)) <> 0
    '[PIERCAN.SECU.KAU17] = (secu5 And (2 ^ 15)) <> 0
 
  
End Sub

Private Sub secu14_Var_ValueChange()
    Dim secu14 As Long
    secu14 = [PIERCAN.PLC.MW10100.MW10184]
    [PIERCAN.SECU.KAU_ZONE4] = (secu14 And (2 ^ 0)) <> 0
    [PIERCAN.SECU.KAU_ZONE3] = (secu14 And (2 ^ 1)) <> 0
    [PIERCAN.SECU.KAU_ZONE2] = (secu14 And (2 ^ 2)) <> 0
    [PIERCAN.SECU.KAU_ZONE1] = (secu14 And (2 ^ 3)) <> 0
    [PIERCAN.SECU.KAU_ZONE_DEMOU] = (secu14 And (2 ^ 4)) <> 0
    [PIERCAN.SECU.KAU_ZONE_PPNC] = (secu14 And (2 ^ 5)) <> 0
    [PIERCAN.SECU.KAU_ZONE_PPF] = (secu14 And (2 ^ 6)) <> 0
    '[] = (secu14 And (2 ^ 7)) <> 0
    '[] = (secu14 And (2 ^ 8)) <> 0
    

End Sub

'====================================================
' setup lorsque plateau est fini
'====================================================

Sub RT_AjouterVariable_plateau_fini(nomVar As String, num As Integer)
    
    Dim v As class_plateau_fini
    Set v = New class_plateau_fini
    
    Variables.Add nomVar, fvVariableTypeAny
    Set v.objOPCVar = Variables(nomVar)

    v.objOPCVar.EnableEvents = True
    
    Set v.Parent = Me
    v.numero = num
    
    'parent = Me
    
    RT_plateau_fini.Add v

End Sub
'========================= logique plateau fini ============================
Public Sub plateau_fini_change(nomVar As String, val_num_plateau As Integer)

    On Error GoTo Gestion_Erreur
    
    Dim article_actuel As T_ARTICLE
    Dim cuves(4) As T_CUVE
    Dim var_tampon_2066 As Variant
    
    var_tampon_2066 = 0
    index_list = 0

    Debug.Print ("======== plateau_fini_change ============")
    Debug.Print ("variable : " & nomVar & "  valu_num_plateau : " & val_num_plateau)
    If ((Variables(nomVar) = True) Or (Variables(nomVar) = 1) Or (val_num_plateau = Variables("PIERCAN.plateau_sans_of"))) Then
        Debug.Print ("1")
        'ancien plateau retire
        Call Update_OF_EN_COURS(val_num_plateau, "")
        Call Update_OF_A_SUIVRE(val_num_plateau, "")
        
        For index_list = 1 To UBound(list_plateaux_a_suivre())
        
            If ((list_plateaux_prepa(index_list).num_plateau = val_num_plateau) And (list_plateaux_prepa(index_list).of <> "")) And (UBound(list_plateaux_prepa()) > 0) Then
                Debug.Print ("2")
                list_plateaux_prepa(index_list).of = ""
                list_plateaux_prepa(index_list).annule = False
                nb_plateau_prep = nb_plateau_prep - 1
                
            End If
            
            If ((list_plateaux_a_suivre(index_list).num_plateau = val_num_plateau) And (list_plateaux_a_suivre(index_list).of <> "")) And (UBound(list_plateaux_a_suivre()) > 0) Then
                'Insert database
                
                Debug.Print ("2 plateau a suivre present :" & val_num_plateau & " idx:" & index_list & " chg:" & list_plateaux_en_cours(val_num_plateau).chdp _
                   & " annule:" & list_plateaux_a_suivre(val_num_plateau).annule)
               
                Call Update_Version_Affaire(list_plateaux_a_suivre(index_list).num_plateau, list_plateaux_a_suivre(index_list).version_cdt)
                Call Update_OF_EN_COURS(list_plateaux_a_suivre(index_list).num_plateau, list_plateaux_a_suivre(index_list).of)
                
                'TODO verifier si le call doit etre a ce moment pour changement de plateau
                'changement de plateau
                If list_plateaux_a_suivre(val_num_plateau).chdp = True Then
                    
                    If val_num_plateau < 17 Then
                        Call TagSetBit("PIERCAN.PLC.MW2000.MW2042", (val_num_plateau - 1))
                        list_plateaux_en_cours(val_num_plateau).chdp = True
                    Else
                        Call TagSetBit("PIERCAN.PLC.MW2000.MW2044", ((val_num_plateau) - 17))
                        list_plateaux_en_cours(val_num_plateau).chdp = True
                    End If
                Else
                
                     If val_num_plateau < 17 Then
                        Call TagResetBit("PIERCAN.PLC.MW2000.MW2042", (val_num_plateau - 1))
                        list_plateaux_en_cours(val_num_plateau).chdp = False
                    Else
                        Call TagResetBit("PIERCAN.PLC.MW2000.MW2044", ((val_num_plateau) - 17))
                        list_plateaux_en_cours(val_num_plateau).chdp = False
                    End If
                    
                End If
                
                
                
                'annuler plateau
                If list_plateaux_a_suivre(val_num_plateau).annule = True Then
                    
                    If val_num_plateau < 17 Then
                        Call TagSetBit("PIERCAN.PLC.MW2000.MW2000", (val_num_plateau - 1))
                        list_plateaux_en_cours(val_num_plateau).annule = True
                        list_plateaux_prepa(val_num_plateau).annule = True
                    Else
                        Call TagSetBit("PIERCAN.PLC.MW2000.MW2002", ((val_num_plateau) - 17))
                        list_plateaux_en_cours(val_num_plateau).annule = True
                        list_plateaux_prepa(val_num_plateau).annule = True
                    End If
                Else
                
                     If val_num_plateau < 17 Then
                        Call TagResetBit("PIERCAN.PLC.MW2000.MW2000", (val_num_plateau - 1))
                        list_plateaux_en_cours(val_num_plateau).annule = False
                    Else
                        Call TagResetBit("PIERCAN.PLC.MW2000.MW2002", ((val_num_plateau) - 17))
                        list_plateaux_en_cours(val_num_plateau).annule = False
                    End If
                    
                End If
                
                'actualisation des listes
                list_plateaux_en_cours(val_num_plateau) = list_plateaux_a_suivre(index_list)
                list_plateaux_a_suivre(index_list).of = ""
                list_plateaux_a_suivre(val_num_plateau).annule = True
                list_plateaux_a_suivre(val_num_plateau).chdp = False
                DoEvents
                
                Debug.Print ("article id : " & list_plateaux_en_cours(val_num_plateau).code_art & "  version : " & list_plateaux_en_cours(val_num_plateau).version_cdt)
                'recup info database
                article_actuel = Get_ARTICLE(Trim(list_plateaux_en_cours(val_num_plateau).code_art), list_plateaux_en_cours(val_num_plateau).version_cdt)
                
                'presence cuve
                For index_cuve = 0 To 4
                    If IsNull(article_actuel.mat_cuve(index_cuve)) = False Then
                        list_plateaux_en_cours(val_num_plateau).presence_cuve(index_cuve) = 1
                    Else
                        list_plateaux_en_cours(val_num_plateau).presence_cuve(index_cuve) = 0
                    End If
                    Debug.Print ("presence cuve " & index_cuve & " : " & list_plateaux_en_cours(val_num_plateau).presence_cuve(index_cuve))
                Next index_cuve
                
                'talcage
                If article_actuel.cycle_Talcage = 1 Or article_actuel.cycle_Talcage = True Then
                    list_plateaux_en_cours(val_num_plateau).cycle_Talcage = 1
                Else
                    list_plateaux_en_cours(val_num_plateau).cycle_Talcage = 0
                End If
                
                Debug.Print ("TALC : " & list_plateaux_en_cours(val_num_plateau).cycle_Talcage)
                'PPNC
                If article_actuel.cycle_PPNC = 1 Or article_actuel.cycle_PPNC = True Then
                    list_plateaux_en_cours(val_num_plateau).cycle_PPNC = 1
                Else
                    list_plateaux_en_cours(val_num_plateau).cycle_PPNC = 0
                End If
                
                Debug.Print ("PPNC: " & list_plateaux_en_cours(val_num_plateau).cycle_PPNC)
                
                'PPF
                If article_actuel.cycle_PPF = 1 Or article_actuel.cycle_PPF = True Then
                    list_plateaux_en_cours(val_num_plateau).cycle_PPF = 1
                Else
                    list_plateaux_en_cours(val_num_plateau).cycle_PPF = 0
                End If
                
                Debug.Print ("PPF : " & list_plateaux_en_cours(val_num_plateau).cycle_PPF)
                
                'transfert des temps
                [PIERCAN.CDT_PLC.sechage_coag] = list_plateaux_en_cours(val_num_plateau).temps_PSCOAG
                [PIERCAN.CDT_PLC.sechage_four_presech] = list_plateaux_en_cours(val_num_plateau).temps_Four_pre_sech
                [PIERCAN.CDT_PLC.sechage_pst1] = list_plateaux_en_cours(val_num_plateau).temps_PST1
                [PIERCAN.CDT_PLC.sechage_rincage] = list_plateaux_en_cours(val_num_plateau).temps_PSR2
                
                'Sleep (500)
                DoEvents
                
                Debug.Print ("sechage_coag : " & [PIERCAN.CDT_PLC.sechage_coag] & " list: " & list_plateaux_en_cours(val_num_plateau).temps_PSCOAG)
                Debug.Print ("sechage_four_presech : " & [PIERCAN.CDT_PLC.sechage_four_presech])
                Debug.Print ("sechage_pst1 : " & [PIERCAN.CDT_PLC.sechage_pst1])
                Debug.Print ("sechage_rincage : " & [PIERCAN.CDT_PLC.sechage_rincage])
                
                var_tampon_2066 = (2 ^ 1) * list_plateaux_en_cours(val_num_plateau).presence_cuve(0) + _
                                                  (2 ^ 2) * list_plateaux_en_cours(val_num_plateau).presence_cuve(1) + _
                                                  (2 ^ 3) * list_plateaux_en_cours(val_num_plateau).presence_cuve(2) + _
                                                  (2 ^ 4) * list_plateaux_en_cours(val_num_plateau).presence_cuve(3) + _
                                                  (2 ^ 5) * list_plateaux_en_cours(val_num_plateau).presence_cuve(4) + _
                                                  (2 ^ 6) * IIf(list_plateaux_en_cours(val_num_plateau).cycle_Talcage = True, 1, 0) + _
                                                  (2 ^ 7) * IIf(list_plateaux_en_cours(val_num_plateau).cycle_PPNC = True, 1, 0) + _
                                                  (2 ^ 8) * IIf(list_plateaux_en_cours(val_num_plateau).cycle_PPF = True, 1, 0) + 1
                
                Debug.Print ("*** info cdt avant *** : " & var_tampon_2066)
                Debug.Print ("*** info cdt avant 2 *** : " & [PIERCAN.PLC.MW2000.MW2066])
                [PIERCAN.PLC.MW2000.MW2066] = var_tampon_2066
                Debug.Print ("*** info cdt apres *** : " & var_tampon_2066)
                Debug.Print ("*** info cdt apres 2*** : " & [PIERCAN.PLC.MW2000.MW2066])
                DoEvents
                Debug.Print ("*** info cdt apres 3*** : " & var_tampon_2066)
                Debug.Print ("*** info cdt apres 4*** : " & [PIERCAN.PLC.MW2000.MW2066])
                
                Debug.Print "envoi des donnees a l'automate ok"
                
                '============= Calcul temps de trempe ============
                For index_cuve = 0 To 4
                    If list_plateaux_en_cours(val_num_plateau).presence_cuve(index_cuve) = True Then
                        list_plateaux_en_cours(val_num_plateau).cuves(index_cuve).palier = Get_PALIER(list_plateaux_en_cours(val_num_plateau).code_art, list_plateaux_en_cours(val_num_plateau).version_cdt, (index_cuve + 1))
                        For ligne = 0 To UBound(list_plateaux_en_cours(val_num_plateau).cuves(index_cuve).palier)
                            'cas 1ere ligne
                            If ligne = 0 Then
                                delta_z = Abs(list_plateaux_en_cours(val_num_plateau).cuves(index_cuve).palier(ligne).z)
                            Else
                                'calcul temps de trempe : temps_tremp = temps_tremp + delta_z * 1/vitesse + attente
                                delta_z = Abs(list_plateaux_en_cours(val_num_plateau).cuves(index_cuve).palier(ligne).z - list_plateaux_en_cours(val_num_plateau).cuves(index_cuve).palier(ligne - 1).z)
                            End If
                            
                            list_plateaux_en_cours(val_num_plateau).cuves(index_cuve).temps_trempe = Int(list_plateaux_en_cours(val_num_plateau).cuves(index_cuve).temps_trempe + (delta_z * (1 / list_plateaux_en_cours(val_num_plateau).cuves(index_cuve).palier(ligne).vitesse)) + list_plateaux_en_cours(val_num_plateau).cuves(index_cuve).palier(ligne).attente)
                        Next
                    End If
                Next index_cuve
                  
                
                list_plateaux_prepa(val_num_plateau) = list_plateaux_a_suivre(val_num_plateau)
                
                Variables(nomVar) = False
                DoEvents
                [PIERCAN.plateau_sans_of] = 0
                DoEvents
                Exit Sub
                
            Else
            
                If (list_plateaux_prepa(index_list).annule = True) And (list_plateaux_prepa(index_list).num_plateau = val_num_plateau) And (UBound(list_plateaux_prepa()) > 0) Then
                
                    list_plateaux_prepa(index_list).of = ""
                    list_plateaux_prepa(index_list).annule = True
                    nb_plateau_prep = nb_plateau_prep - 1
                    
                End If
                
                If (list_plateaux_a_suivre(index_list).annule = True) And (list_plateaux_a_suivre(index_list).num_plateau = val_num_plateau) And (UBound(list_plateaux_a_suivre()) > 0) Then
                
                    Debug.Print ("4 pas de plateau a suivre pour le plateau " & val_num_plateau)
                
                    list_plateaux_en_cours(val_num_plateau) = list_plateaux_a_suivre(index_list)
                    
                    list_plateaux_a_suivre(index_list).of = ""
                    list_plateaux_a_suivre(index_list).annule = True
                    
                    Variables(nomVar) = False
                    'envoie du plateau annule a l'automate
                    If val_num_plateau < 17 Then
                        Call TagSetBit("PIERCAN.PLC.MW2000.MW2000", (val_num_plateau - 1))
                    Else
                        TagSetBit "PIERCAN.PLC.MW2000.MW2002", ((val_num_plateau) - 17)
                    End If
                    
                    'changement de plateau
                    If list_plateaux_a_suivre(val_num_plateau).chdp = True Then
                        
                        If val_num_plateau < 17 Then
                            Call TagSetBit("PIERCAN.PLC.MW2000.MW2042", (val_num_plateau - 1))
                        Else
                            TagSetBit "PIERCAN.PLC.MW2000.MW2044", ((val_num_plateau) - 17)
                        End If
                    Else
                
                        If val_num_plateau < 17 Then
                            Call TagResetBit("PIERCAN.PLC.MW2000.MW2042", (val_num_plateau - 1))
                        Else
                            TagResetBit "PIERCAN.PLC.MW2000.MW2044", ((val_num_plateau) - 17)
                        End If
                    
                    End If
                
                    [PIERCAN.PLC.MW2000.MW2066] = 1
                    Debug.Print ("*** Cas Plateau Annule [PIERCAN.PLC.MW2000.MW2066]: *** : " & [PIERCAN.PLC.MW2000.MW2066])
                    
                    DoEvents
                    list_plateaux_a_suivre(val_num_plateau).chdp = False
                    list_plateaux_prepa(val_num_plateau).chdp = False
                    DoEvents
                    [PIERCAN.plateau_sans_of] = 0
                    DoEvents
                    
                    Exit Sub
                        
                End If
                
                
            End If
        Next index_list
        
        'Si on veut laisser une derniere chance d'ajouter un of sur le plateau
        
        'res = MsgBox("ATTENTION PLATEAU FINI SANS OF " & vbCrLf & vbCrLf & "Voulez-vous associer un OF au plateau ? " & val_num_plateau, vbYesNo, "Action Requise !")
        'TODO si pas d'of, alerter operateur
        'If res = vbYes Then
            'TagResetBit "PIERCAN.PLC.MW2000.MW2036", 14 ' OF NON valider par la supervision = OFF
            'Debug.Print ("go to PLATEAU")
            'Mimics.Close
            'Mimics.Open ("PLATEAUX")
        'Else
            'MsgBox " Il vous reste environ 10 min pour annuler le plateau ou effectuer un changement de plateau, sans aucune action de votre part la production s'arretera. ", vbInformation
            'TagResetBit "PIERCAN.PLC.MW2000.MW2036", 14 ' OF NON valider par la supervision = OFF
        'End If
        '[PIERCAN.plateau_sans_of] = val_num_plateau
        'DoEvents
    End If
    
    Exit Sub
    
Gestion_Erreur:
    Global_Module.ErrorManagement "plateau_fini_change", "ThisProject", Err.Description
End Sub


'====================================================
'copie et lecture des donnees IBC
'====================================================
Private Sub create_ibc_planning_file()

'Creation d'un fichier de sauvegarde pour les plannings des ibcs
    Dim FileIBCPlanning As Integer
    Dim i As Integer
    Dim cuves As Variant
    Dim cuve As Variant
    Dim modes As Variant
    Dim mode As Variant
    
    On Error GoTo ErrHandler
    
    cuves = Array("CUVE1", "CUVE3", "CUVE4")
    modes = Array("Mode1", "Mode2", "Mode3", "Mode4")
    
    FileNum = FreeFile
    Open "C:\ARC Informatique\PcVue 16\Usr\emulsion-4-piercan\planning_ibc" For Output As #FileNum
    
    For Each cuve In cuves
    
        Print #FileNum, cuve
        
        Print #FileNum, Variables("PIERCAN.CUVES." & cuve & ".IBC.PLANNING.mode_de_fonctionnement") '1 2 4 8 16 32
        
        For Each mode In modes
            
            Print #FileNum, mode
            
            For i = 0 To 23
                Print #FileNum, Variables("PIERCAN.CUVES." & cuve & ".IBC.PLANNING." & mode & ".H" & i)
            Next i
        Next mode
        
    Next cuve
    
    Close #FileNum
    Exit Sub
    
ErrHandler:
    On Error Resume Next
    If FileNum <> 0 Then Close #FileNum
    Message "Erreur IBC", "Erreur : " & Err.Description

End Sub

Private Sub read_ibc_planning_file()
    'Lecture du fichier de sauvegarde des plannings IBC

    Dim FileNum As Integer
    Dim i As Integer
    Dim cuve As String
    Dim mode As String
    Dim valeur As String
    Dim mode_selected As String
    
    On Error GoTo ErrHandler
    
    FileNum = FreeFile
    
    Open "C:\ARC Informatique\PcVue 16\Usr\emulsion-4-piercan\planning_ibc" For Input As #FileNum

    For nbcuve = 1 To 3
        'Lecture de la cuve
        Line Input #FileNum, cuve
        
        Line Input #FileNum, mode_selected
        
        Variables("PIERCAN.CUVES." & cuve & ".IBC.PLANNING.mode_de_fonctionnement") = mode_selected
    
        'Lecture des 4 modes
        For nbmode = 1 To 4
    
            'Lecture du mode
            Line Input #FileNum, mode
    
            'Lecture des 24 heures
            For i = 0 To 23
    
                Line Input #FileNum, valeur
                
                valeur = Trim(valeur)
                
                If valeur = "False" Or valeur = "0" Then
                    Variables("PIERCAN.CUVES." & cuve & ".IBC.PLANNING." & mode & ".H" & i) = 0
                Else
                    Variables("PIERCAN.CUVES." & cuve & ".IBC.PLANNING." & mode & ".H" & i) = 1
                End If
    
            Next i
    
        Next nbmode
        
    Next nbcuve

    Close #FileNum
    
    Exit Sub
    
ErrHandler:
    On Error Resume Next
    If FileNum <> 0 Then Close #FileNum
    
End Sub

'================================ TRACE =========================================
'0 annule la trace
Private Sub etat_plateau(empl_plateau_1, empl_plateau_2, text2, text1, var_event As Long, ope As Long, Message As Long, equi As Long, lieu1 As Long, lieu2 As Long, trace_ok As Boolean)  'temps_of
    If (empl_plateau_1 <> 0) Then
        If (empl_plateau_1 Mod 10 = 1) And ((empl_plateau_1 \ 10) <= UBound(list_plateaux_en_cours)) Then
            list_plateaux_en_cours(empl_plateau_1 \ 10).etat_1 = text1
            'list_plateaux_en_cours(empl_plateau_1 \ 10).temps_restant = list_plateaux_en_cours(empl_plateau_1 \ 10).temps_restant - temps_of
        Else
            list_plateaux_en_cours(empl_plateau_1 \ 10).etat_2 = text1
            'list_plateaux_en_cours(empl_plateau_1 \ 10).temps_restant = list_plateaux_en_cours(empl_plateau_1 \ 10).temps_restant - temps_of
        End If
        
        If trace_ok = True And (Message <> 0) Then
            Trace list_plateaux_en_cours(empl_plateau_1 \ 10).of, list_plateaux_en_cours(empl_plateau_1 \ 10).affaire, var_event, ope, Message, equi, lieu1, "", 0, list_plateaux_en_cours(empl_plateau_1 \ 10).code_art, list_plateaux_en_cours(empl_plateau_1 \ 10).version_cdt, (empl_plateau_1 \ 10)
        End If
    End If
    
    If (empl_plateau_2 <> 0) Then
        If (empl_plateau_2 Mod 10 = 1) And ((empl_plateau_2 \ 10) <= UBound(list_plateaux_en_cours)) Then
            list_plateaux_en_cours(empl_plateau_2 \ 10).etat_1 = text2
            'list_plateaux_en_cours(empl_plateau_2 \ 10).temps_restant = list_plateaux_en_cours(empl_plateau_2 \ 10).temps_restant - temps_of
        Else
            list_plateaux_en_cours(empl_plateau_2 \ 10).etat_2 = text2
            'list_plateaux_en_cours(empl_plateau_2 \ 10).temps_restant = list_plateaux_en_cours(empl_plateau_2 \ 10).temps_restant - temps_of
        End If
        
        If trace_ok = True And (Message <> 0) And (lieu2 <> 0) Then
            Trace list_plateaux_en_cours(empl_plateau_2 \ 10).of, list_plateaux_en_cours(empl_plateau_2 \ 10).affaire, var_event, ope, Message, equi, lieu2, "", 0, list_plateaux_en_cours(empl_plateau_2 \ 10).code_art, list_plateaux_en_cours(empl_plateau_2 \ 10).version_cdt, (empl_plateau_2 \ 10)
        End If
    End If
    
        
End Sub

Private Sub trace_cuve(empl_plateau_1, empl_plateau_2, debut_fin_trempe As Long, lieu_num_cuve As Long)

    On Error GoTo Gestion_Erreur

    'exemple : trace_cuve (EmplRef_11_12_Var And &HFFFF&), (EmplRef_11_12_Var \ (2 ^ 16)), type_message.Fin_Trempe, type_lieu.CUVE1
    If trac_ok_var = True Then
        'trace trempe
        If (empl_plateau_1) <> 0 Then
            Trace list_plateaux_en_cours((empl_plateau_1) \ 10).of, list_plateaux_en_cours((empl_plateau_1) \ 10).affaire, type_evenement.PRODUCTION, type_operation.created_HMI, debut_fin_trempe, type_equipement.cuve, lieu_num_cuve, type_operation.created_HMI, 0, list_plateaux_en_cours((empl_plateau_1) \ 10).code_art, list_plateaux_en_cours((empl_plateau_1) \ 10).version_cdt, (empl_plateau_1) / 10
        End If
        
        'Debug.Print ("/*/*/ debut ou fin trempe : " & debut_fin_trempe & "*/*/*/ plateau :" & empl_plateau_1)
        If (empl_plateau_2) <> 0 Then
            Trace list_plateaux_en_cours((empl_plateau_2) \ 10).of, list_plateaux_en_cours((empl_plateau_2) \ 10).affaire, type_evenement.PRODUCTION, type_operation.created_HMI, debut_fin_trempe, type_equipement.cuve, lieu_num_cuve, type_operation.created_HMI, 0, list_plateaux_en_cours((empl_plateau_2) \ 10).code_art, list_plateaux_en_cours((empl_plateau_2) \ 10).version_cdt, ((empl_plateau_2)) / 10
        End If
        
        Debug.Print ("**lieu : " & lieu_num_cuve)
        
        If lieu_num_cuve = type_lieu.CUVE1 Then
            
            Debug.Print ("**debut fin trempe 1 : " & debut_fin_trempe)
            If debut_fin_trempe = type_message.Debut_trempe Then
                If [PIERCAN.debut_trempe_cuve1] = False Then
                    [PIERCAN.cuves.CUVE1.temps_restant] = list_plateaux_en_cours((empl_plateau_1 And &HFFFF&) / 10).temps_trempe_cuve1
                    DoEvents
                    Debug.Print ("temps restant trace 1 : " & [PIERCAN.cuves.CUVE1.temps_restant])
                    [PIERCAN.debut_trempe_cuve1] = 1
                End If
            End If
            
            If debut_fin_trempe = type_message.Fin_trempe Then
                If [PIERCAN.debut_trempe_cuve1] = True Then
                    [PIERCAN.debut_trempe_cuve1] = 0
                    [PIERCAN.cuves.CUVE1.temps_restant] = 0
                    Debug.Print ("fin cuve 1")
                End If
            End If
            
            DoEvents
        End If
        
        If lieu_num_cuve = type_lieu.CUVE2 Then
            
            Debug.Print ("**debut fin trempe 2 : " & debut_fin_trempe)
            If debut_fin_trempe = type_message.Debut_trempe Then
                If [PIERCAN.debut_trempe_cuve2] = False Then
                    Debug.Print ("**plateau ne : " & (empl_plateau_1 And &HFFFF&) \ 10)
                    [PIERCAN.cuves.CUVE2.temps_restant] = list_plateaux_en_cours((empl_plateau_1 And &HFFFF&) / 10).temps_trempe_cuve2
                    DoEvents
                    Debug.Print ("temps restant trace 2 : " & [PIERCAN.cuves.CUVE2.temps_restant])
                    [PIERCAN.debut_trempe_cuve2] = 1
                End If
            End If
            
            If debut_fin_trempe = type_message.Fin_trempe Then
                If [PIERCAN.debut_trempe_cuve2] = True Then
                    [PIERCAN.debut_trempe_cuve2] = 0
                    [PIERCAN.cuves.CUVE2.temps_restant] = 0
                    Debug.Print ("fin cuve 2")
                End If
            End If
            
            DoEvents
        End If
        
        If lieu_num_cuve = type_lieu.CUVE3 Then
            
            Debug.Print ("**debut fin trempe 3 : " & debut_fin_trempe)
            If debut_fin_trempe = type_message.Debut_trempe Then
                If [PIERCAN.debut_trempe_cuve3] = False Then
                    [PIERCAN.cuves.CUVE3.temps_restant] = list_plateaux_en_cours((empl_plateau_1 And &HFFFF&) / 10).temps_trempe_cuve3
                    DoEvents
                    Debug.Print ("temps restant trace 3 : " & [PIERCAN.cuves.CUVE3.temps_restant])
                    [PIERCAN.debut_trempe_cuve3] = 1
                End If
            End If
            
            If debut_fin_trempe = type_message.Fin_trempe Then
                If [PIERCAN.debut_trempe_cuve3] = True Then
                    [PIERCAN.debut_trempe_cuve3] = 0
                    [PIERCAN.cuves.CUVE3.temps_restant] = 0
                    Debug.Print ("fin cuve 3")
                End If
            End If
            
            DoEvents
        End If
        
        If lieu_num_cuve = type_lieu.CUVE4 Then
            
            Debug.Print ("**debut fin trempe 4 : " & debut_fin_trempe)
            If debut_fin_trempe = type_message.Debut_trempe Then
                If [PIERCAN.debut_trempe_cuve4] = False Then
                    Debug.Print ("**plateau ne : " & (empl_plateau_1 And &HFFFF&) \ 10)
                    [PIERCAN.cuves.CUVE4.temps_restant] = list_plateaux_en_cours((empl_plateau_1 And &HFFFF&) / 10).temps_trempe_cuve4
                    DoEvents
                    Debug.Print ("temps restant trace 4 : " & [PIERCAN.cuves.CUVE4.temps_restant])
                    [PIERCAN.debut_trempe_cuve4] = 1
                End If
            End If
            
            If debut_fin_trempe = type_message.Fin_trempe Then
                If [PIERCAN.debut_trempe_cuve4] = True Then
                    [PIERCAN.debut_trempe_cuve4] = 0
                    [PIERCAN.cuves.CUVE4.temps_restant] = 0
                    Debug.Print ("fin cuve 4")
                End If
            End If
            
        End If
        
        If lieu_num_cuve = type_lieu.CUVE5 Then
            
            Debug.Print ("**debut fin trempe 5 : " & debut_fin_trempe)
            If debut_fin_trempe = type_message.Debut_trempe Then
                If [PIERCAN.debut_trempe_cuve5] = False Then
                    Debug.Print ("**plateau ne : " & (empl_plateau_1 And &HFFFF&) \ 10)
                    [PIERCAN.cuves.CUVE5.temps_restant] = list_plateaux_en_cours((empl_plateau_1 And &HFFFF&) / 10).temps_trempe_cuve5
                    DoEvents
                    Debug.Print ("temps restant trace 5 : " & [PIERCAN.cuves.CUVE5.temps_restant])
                    [PIERCAN.debut_trempe_cuve5] = 1
                End If
            End If
            
            If debut_fin_trempe = type_message.Fin_trempe Then
                If [PIERCAN.debut_trempe_cuve5] = True Then
                    [PIERCAN.debut_trempe_cuve5] = 0
                    [PIERCAN.cuves.CUVE5.temps_restant] = 0
                    Debug.Print ("fin cuve 5")
                End If
            End If
            
        End If
        
        lieu_num_cuve = 0
        DoEvents
    End If
        'If debut_fin_trempe = type_message.debut_trempe Then
        '    If bit_start_trempe = False Then
        '        temps_restant_cuve = list_plateaux_en_cours((empl_plateau_1 And &HFFFF&) / 10).temps_trempe_cuve1
        '        Debug.Print ("temps restant trace" & temps_restant_cuve)
        '        bit_start_trempe = 1
        '    End If
        'Else
        '    If bit_start_trempe = True Then
        '        bit_start_trempe = 0
        '        temps_restant_cuve = 0
        '    End If
        'End If
    Exit Sub

Gestion_Erreur:
    Global_Module.ErrorManagement "trace_cuve", "ThisProject", Err.Description
End Sub


'*** Redemarrage du projet en cas d'arret du VBA ***
'*********************************************************************************************************
Sub RedemarrageVBA()
    On Error GoTo Gestion_Erreur
    fvProject_StartupComplete
    Sleep (100)
    On Error GoTo 0
    Exit Sub
Gestion_Erreur:
    Global_Module.ErrorManagement "RedemarrageVBA", "ThisProject", Err.Description
End Sub


Sub refresh()

On Error GoTo Gestion_Erreur

    trac_ok_var = False
    inhibition_plateau_1_16_Var_ValueChange
    inhibition_plateau_17_32_Var_ValueChange
    
    plateau_fini_1_16_Var_ValueChange
    plateau_fini_17_32_Var_ValueChange
    changer_plateau_1_16_Var_ValueChange
    changer_plateau_17_32_Var_ValueChange
    
    
    'Cuves
    
    Etat_Couv_Cuve_Var_ValueChange
    Etat_Agit_Cuve_Var_ValueChange
    Etat_IBC_Cuve_Var_ValueChange
    
    'Presence_Cuve_Var_ValueChange
    
    'E4 general
    API_Pcvue_echange_1_Var_ValueChange
    'Pcvue_API_echange_1_Var_ValueChange
    
    
    'R1
    PCVUE_Etat_R1_Var_ValueChange
    Etat_R1_Var_ValueChange
    Cmd_R1_Var_ValueChange
    R1_Etat_prehenseur_Var_ValueChange
    'R2
    PCVUE_Etat_R2_Var_ValueChange
    Etat_R2_Var_ValueChange
    Cmd_R2_Var_ValueChange
    R2_Etat_prehenseur_Var_ValueChange
    'R3
    PCVUE_Etat_R3_Var_ValueChange
    Etat_R3_Var_ValueChange
    Cmd_R3_Var_ValueChange
    R3_Etat_prehenseur_Var_ValueChange
    'R4
    PCVUE_Etat_R4_Var_ValueChange
    Etat_R4_Var_ValueChange
    Cmd_R4_Var_ValueChange
    R4_Etat_prehenseur_Var_ValueChange
    'R5
    PCVUE_Etat_R5_Var_ValueChange
    Etat_R5_Var_ValueChange
    Cmd_R5_Var_ValueChange
    R5_Etat_prehenseur_Var_ValueChange
    
    
    'Plateaux
    If [PIERCAN.CYCLE.E4_ok] <> 0 And [PIERCAN.CYCLE.Api_Ethernet_Run] <> 0 Then
        EmplRef_1_2_Var_ValueChange
        EmplRef_3_4_Var_ValueChange
        EmplRef_5_6_Var_ValueChange
        EmplRef_7_8_Var_ValueChange
        EmplRef_9_10_Var_ValueChange
        EmplRef_11_12_Var_ValueChange
        EmplRef_13_14_Var_ValueChange
        EmplRef_15_16_Var_ValueChange
        EmplRef_17_18_Var_ValueChange
        EmplRef_19_20_Var_ValueChange
        EmplRef_21_22_Var_ValueChange
        EmplRef_23_24_Var_ValueChange
        EmplRef_25_26_Var_ValueChange
        EmplRef_27_28_Var_ValueChange
        EmplRef_29_30_Var_ValueChange
        EmplRef_31_32_Var_ValueChange
        EmplRef_33_34_Var_ValueChange
        EmplRef_35_36_Var_ValueChange
        EmplRef_37_38_Var_ValueChange
        EmplRef_39_40_Var_ValueChange
        EmplRef_41_42_Var_ValueChange
        EmplRef_43_44_Var_ValueChange
        EmplRef_45_46_Var_ValueChange
        EmplRef_47_48_Var_ValueChange
        EmplRef_49_50_Var_ValueChange
        EmplRef_51_52_Var_ValueChange
        EmplRef_53_54_Var_ValueChange
        EmplRef_55_56_Var_ValueChange
        EmplRef_57_58_Var_ValueChange
        EmplRef_59_60_Var_ValueChange
        EmplRef_61_62_Var_ValueChange
        EmplRef_63_64_Var_ValueChange
        EmplRef_65_66_Var_ValueChange
        EmplRef_67_68_Var_ValueChange
        EmplRef_69_70_Var_ValueChange
        EmplRef_71_72_Var_ValueChange
        EmplRef_73_74_Var_ValueChange
        EmplRef_75_76_Var_ValueChange
        EmplRef_77_78_Var_ValueChange
        EmplRef_79_80_Var_ValueChange
        EmplRef_81_82_Var_ValueChange
        EmplRef_83_84_Var_ValueChange
        EmplRef_85_86_Var_ValueChange
        EmplRef_87_88_Var_ValueChange
        EmplRef_89_90_Var_ValueChange
        EmplRef_91_92_Var_ValueChange
        EmplRef_93_94_Var_ValueChange
        EmplRef_95_96_Var_ValueChange
        EmplRef_97_98_Var_ValueChange
        EmplRef_99_100_Var_ValueChange
        EmplRef_101_102_Var_ValueChange
        EmplRef_103_104_Var_ValueChange
        EmplRef_105_106_Var_ValueChange
        EmplRef_107_108_Var_ValueChange
        EmplRef_109_110_Var_ValueChange
        'EmplRef_111_112_Var_ValueChange
        'EmplRef_113_114_Var_ValueChange
        'EmplRef_115_116_Var_ValueChange
        'EmplRef_117_118_Var_ValueChange
        'EmplRef_119_120_Var_ValueChange
    End If
    
    'Four
    PP_four_Var_ValueChange
    PT_four_Var_ValueChange
    etat_global_four_Var_ValueChange
    info_four_Var_ValueChange
    
    'Four de pre-sechage
    capteur_FPS_Var_ValueChange
    'cmd_FPS_var_ValueChange
    
    'erreur
    msg_erreur_1_16_Var_ValueChange
    msg_erreur_17_32_Var_ValueChange
    msg_erreur_33_48_Var_ValueChange
    msg_erreur_49_64_Var_ValueChange
    
    'secu
    secu1_Var_ValueChange
    secu2_Var_ValueChange
    secu3_Var_ValueChange
    secu4_Var_ValueChange
    secu5_Var_ValueChange
    secu14_Var_ValueChange

    trac_ok_var = True
    
    Exit Sub

Gestion_Erreur:
    Global_Module.ErrorManagement "refresh", "ThisProject", Err.Description
End Sub
