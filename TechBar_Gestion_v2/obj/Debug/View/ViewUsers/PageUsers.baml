   M S B A M L   `   `   `  ����M  ITechBar_Gestion_v2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:TechBar_Gestion_v2.View.ViewUsers!TechBar_Gestion_v2.View.ViewUsers  5      1    +TechBar_Gestion_v2.View.ViewUsers.PageUsers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:TechBar_Gestion_v2.View.ViewUsers     5      g cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae	 aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai
 eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj  fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag! cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac" _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag# cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah$ dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae% aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!     	 
                        ! " # $ % 5      .��5
      �   � RowDefinitions  5   
   �� 5      $��9* �6   �� 5      $��1* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��0.2* �6#   �� 5      $��8* �6#   �� 5      $
��0.2* �6#     5      �� 5      $
��1.5* �6    �� 5      $��8* �6    �� 5      $
��0.5* �6    .+�5      &   System.Windows.Controls.DataGrid  -   5        $��DatagridUser��5         Dtg_BsStyle#��[  6+   $��1��6P   $��1��6`      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ 
Operations��6-      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6S      CellTemplate 5!      �� 5"      .R�5#   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5$   &   �� -   5          DatagridButton#��[ 5$   C   .��5%   *   . ! (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ PencilOutline=�6@   5&   '   �� 5'   &   -   5        $��5 0 0 0q�5'   -   #��[ 6W   .��5(   *     $ DeleteOutline=�6@   5)   '   �� 5*   &   -   5        $��5 0 0 0q�5*   -   #��[ 6\   .��5+   *     $ CardMultipleOutline=�6@   5,   '   5-   #   5.      50      52      54      � 5:   
   $��1��6    5;      �� 5<      $��6* �6#   �� 5=      $��3* �6#   �� 5>      $
��0.5* �6#   .+�5A      �� -   5        $��1q�5A      $��1��6:     
BaseButton#��[ 6J   .��5B      �� $��ajouter un utilisateur +��6   
�������$��20(�6N   5C      �� 5E      -   5        $��1q�5E      $��2��6:   #��[ 6J   .��5F        $ Refresh=�6(   5G      5I      � 5M   
   -   5        	 �Name$	 popup_modcontact��5M      ��.  $��Center=�69   $
��auto��6L   $
��auto��6Z   .��5N      ��   PopUp_Border#��[ 6   ._�5O      �� ���#EFF2F7$ Vertical=�62   .+�5P      �� $ 
Horizontal=�6!   .+�5Q      �� $4��.Voulez vous vraiment modifier ces information?��6      PopUp_LB#��[ 6Y   5R      �� 5S      $ 
Horizontal=�6!   .+�5T      �� -   5        #��[ 5T   !   $��Annuler��6E   6v   �� 5U      -	   5        #��[ 5U   !   $��	Confirmer��6E   6y   5V      5W      5X      5Y      � 5[   
   -
   5        $	 popup_delcontact��5[      ��.  $��Center=�69   $
��auto��6L   $
��auto��6Z   .��5\      �� #��[ 6   ._�5]      �� ���#EFF2F7$ Vertical=�62   .+�5^      �� $ 
Horizontal=�6!   .+�5_      �� $4��.Voulez vous vraiment supprimer cet utilisateur��6    #��[ 6Y   5`      �� 5a      $ 
Horizontal=�6!   .+�5b      �� -   5        #��[ 5b   !   $��Annuler��6E   6v   �� 5c      -   5        #��[ 5c   !   $��	Confirmer��6E   6y   5d      5e      5f      5g      � 5i   
   -   5        $	 popup_rfidcontact��5i      ��.  $��Center=�6:   $
��auto��6M   $
��auto��6[   .��5j      �� #��[ 6   ._�5k      �� ���#EFF2F7$ Vertical=�62   .+�5l      �� $ 
Horizontal=�6!   .+�5m      �� $K��EVoulez vous vraiment mettre le refid du lecteur dans cet urilisateur?��6    #��[ 6p   5n      �� 5o      $ 
Horizontal=�6!   .+�5p      �� -   5        #��[ 5p   !   $��Annuler��6E   6~   �� 5q      -   5        #��[ 5q   !   $��	Confirmer��6E   6�   5r      5s      5t      5u      � 5w   
   -   5        $	 popup_adduser��5w      ��.  $��Center=�66   $
��auto��6I   $
��auto��6W   .��5x      �� #��[ 6   ._�5y      �� ���#EFF2F7$ Vertical=�62   .+�5z      �� $ 
Horizontal=�6!   .+�5{      �� $	��Nom��6    #��[ 6.   �� 5|      -   5        
 ��Name$
 TB_LastName��5|   "   $	��150��67     searchTextbox#��[ 6C   5}      �� 5~      $ 
Horizontal=�6!   .+�5      �� $��Prenom��6    #��[ 61   �� 5�      -   5        $
 TB_Name��5�   "   $	��150��63   #��[ 6?   5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��
RFIDNumber��6    #��[ 65   �� 5�      -   5        $��5 0 0 0q�5�   !   #��[ 6P   .��5�        $ CardMultipleOutline=�64   5�      �� 5�      -   5        $
 TB_RFIDNumber��5�   "   $	��150��69   #��[ 6E   5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��Email��6    #��[ 60   �� 5�      -   5        $
 TB_Email��5�   "   $	��150��64   #��[ 6@   5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��Crédit��6    #��[ 61   �� 5�      -   5        $
 	TB_Credit��5�   "   $	��150��65   #��[ 6A   5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� -   5        #��[ 5�   !   $��Annuler��6E   6p   �� 5�      -   5        #��[ 5�   !   $��	Confirmer��6E   6s   5�      5�      5�      5�      5�      5�      