   M S B A M L   `   `   `  ����E  AAppTournoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AppTournoi
AppTournoi  5   	       AppTournoi.GestionSport   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AppTournoi     5   	     � Title$'  !Gestion des Sports (Gestionnaire)��5   	   $	��450��63   $	��800��6@   $	��450��5	   	   $	��800��6   .��5
      � ���#d7ecee � ColumnDefinitions 5   
   �� 5      $
��121* �6   �� 5      $	��39* �6    � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ lvSportGestion��5      $��15,15,15,15q�6+   $��6��6@    � ContextMenu 5      �� 5      -   5        $��ContextMenuListTournoi��5      .@�5      m� -   5        $!��MenuContextSupprimerTournoi��5      $��Supprimer un Tournoi��6B   6`   m� 5      -   5        $ ��MenuContextModifierTournoi��5      $��Modifier un Tournoi��6A   6^   5      ��5      �� 5       .R�5!      �� �� 5"      
���   ��6   �� *
Intitule+69   5#      5$      5&      �� 5(   
   $��Intitulé du sport : ��6   
���   �$��Center=�6B   $��Center=�6]   $��1��6z   $��1��6�   �� 5*   
   -   5         ��Name$ tbSport��5*      ���#bdcdca$��10,10,10,10q�68   $��2��6M   $��1��6Z   6j   �� 5-   
   -   5         ��Name$ ButtonAjouterSport��5-      $��Ajouter le sport��6-   $	��149��6H   $��43��6T   $��Center=�6`   $��Center=�6{   $��3��6�   $��1��6�   {�.  6�   �� 5.   
   -   5        $��Quitter��5.      $	��150��6#   $��43��6/   $��CEnter=�6;   $��Center=�6V   $��4��6�   $��1��6�   50      51      