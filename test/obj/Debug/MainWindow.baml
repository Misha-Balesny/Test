   M S B A M L   `   `   `  ?????  ;test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:testtest  5   	       test.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:test     5   	     ? Title$
  Test??5   	   $	??450??6   $	??800??6#   $	??450??5	   	   $	??800??6   $	??450??6(   $	??800??68   .??5
      ? .+?5   
   ?? -   5        $??userList??5      $??Hidden=?6$   $??Visible=?5      $	??Top=?5      ??.  $	??360??5      $
??Left=?6    ??5      ?? *Users+ ?? SelectedItem 5   ;   ?? *SelectedUser+ ?? View 5      ?? 5      .P?5      ??  ?? Width$	 150??6P    ?? DisplayMemberBinding 6%   ??  ?? Path$
 User?.??6\   Name6b   ?? 5      $ 70??6T    6%   ?? $ AvgSteps?.??6_   
avg. Steps6k   ?? 5      $ 70??6P    6%   ?? $
 Best?.??6[   Best6a   ?? 5      $ 50??6Q    6%   ?? $ Worst?.??6\   Worst6c   5      ??5      ?? 5       ?? 
TargetType" ??6   .?5      ??  ?? Property ? ?? ?? Value 63   ?? $ Color?5      5      ?? 5   
   ??6   ?? $ Lines???5       ?? 5!      .R?5"      ?? 	 ??Name$	 Chart??60   
???????$??Right=?6?   $	??Top=?5#      $	??380??6)   $	??420??66   $??0,0,0,0q?6B   5$      ??5&      ?? 5'      .R?5(      ?? 	
 ?? X1
 6   ?? *X1+	 ?? Y1 6-   ?? *Y1+	 ?? X2 6?   ?? *X2+	 ?? Y2 6Q   ?? *Y2+??6c   ?? *Color+??6|   ?? *	Thickness+6?   5)      5+      ?? 5-   
   -   5         ??Name$ Button??5-      $??	Save Data??5.      $??Right=?6%   $??Bottom=?5/      $??30??6,   $	??100??68   $??	0,0,20,20q?6D   ??5-   !   ?? *SaveCommand+5/   D   50      51      