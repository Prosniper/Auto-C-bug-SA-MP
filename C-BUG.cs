{$CLEO .cs}

//-------------MAIN---------------
03A4: script_name "CBUG2" 

00D6: if 
0AAB:    does_file_exist "CLEO\BY MoquecaDaLGCHP (NÃO DELETE!)"
004D: goto_if_false @CBUG2_9


0B04:   copy_file "CLEO\Realista.CS" to "CLEO\BY MoquecaDaLGCHP (NÃO DELETE!)"
00BC: print_now 'CBUG_2' time 10000 flag 1 

:CBUG2_9
0001: wait 0 
$4 = 0 

:CBUG2_20
0001: wait 0 
0597:   is_char_ducking $PLAYER_ACTOR 
004D: goto_if_false @CBUG2_66 
$4 = 1 

:CBUG2_43
0001: wait 0 
0597:   is_char_ducking $PLAYER_ACTOR 
004D: goto_if_false @CBUG2_9 
0002: goto @CBUG2_43 

:CBUG2_66
0001: wait 0 
00D6: if or
02D8:   is_char_holding_weapon $PLAYER_ACTOR weapon 24 
02D8:   is_char_holding_weapon $PLAYER_ACTOR weapon 25 
004D: goto_if_false @CBUG2_102 
0002: goto @CBUG2_20 

:CBUG2_102
0001: wait 0 
$4 = 1 

:CBUG2_113
0001: wait 0 
00D6: if or
02D8:   is_char_holding_weapon $PLAYER_ACTOR weapon 24 
02D8:   is_char_holding_weapon $PLAYER_ACTOR weapon 25 
004D: goto_if_false @CBUG2_113 
$4 = 0 
0002: goto @CBUG2_20 


:CBUG_8
0001: wait 0 
00D6: if and
02E0:   is_char_shooting $PLAYER_ACTOR 
   not $4 == 1 
004D: goto_if_false @CBUG_8 
0A8C: write_memory 12006520 size 2 val 255 vp 0 
0001: wait 70 
0812: task_play_anim_non_interruptable $PLAYER_ACTOR anim "HIT_WALK" ifp "PED" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time 1 
0002: goto @CBUG_8 



