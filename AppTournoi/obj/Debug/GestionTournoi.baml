   M S B A M L   `   `   `  ����E  AAppTournoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AppTournoi
AppTournoi  5   	       AppTournoi.GestionTournoi   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AppTournoi     5   	     � Title$)  #Gestion des Tournois (Gestionnaire)��5   	   $	��450��65   $	��800��6B   $	��450��5	   
   $	��800��6   .��5
      � ���#d7ecee � ColumnDefinitions 5   
   �� 5      $
��121* �6   �� 5      $	��39* �6   �� 5      $	��39* �6    � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $
��140* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��50* �6   .+�5   
   �� -   5         ��Name$ lvTournoiGestion��5      $��15,15,15,15q�6-   $��7��6B    � ContextMenu 5      �� 5      -   5        $��ContextMenuListTournoi��5      .@�5      m� -   5        $!��MenuContextSupprimerTournoi��5      $��Supprimer un Tournoi��6B   6`   m� 5      -   5        $ ��MenuContextModifierTournoi��5      $��Modifier un Tournoi��6A   6^   5      ��5!      �� 5"      .R�5#      �� �� 5$      
���   ��6   �� *
Intitule+69    �� 5%      $	� - ��6   
���   �6)    �� 5&      
���   ��6   �� *DateTournoi+ �� StringFormat$ d��6L   5'      5(      5*      �� 5,   
   $��Intitule : ��6   $
��Bold"�6&   $��center=�68   $��center=�6S   $��1��6p   $��1��6}   �� 5-   
   -   5         ��Name$ 
tbIntitule��5-      ���#bdcdca$��10,10,10,10q�6<   $��1��6Q   $��2��6^   6n   �� 5/   
   $��Date : ��6   $
��Bold"�6"   $��center=�64   $��center=�6O   $��2��6l   $��1��6y   (  "System.Windows.Controls.DatePicker  50   
   -   5        $��dpDate��50      $��10,10,10,10q�6#   $��2��68   $��2��6H   6U   �� 54      $��Selectionner le Sport : ��6   $
��Bold"�67   $��Center=�6I   $��Center=�6d   $��3��6�   $��1��6�   �� 55   
   -   5        $ lvSport��55      $��10,10,10,10q�6$   ���#bdcdca$��3��6N   $��2��6[   ��56      �� 57      .R�58      �� �� 59      
���   ��6   �� *
Intitule+69   5:      5;      5=      �� 5?   
   -   5         ��Name$ ButtonAjouter��5?      $��Ajouter��6(   $��Center=�6:   $��Center=�6W   $	��149��6r   $��43��6~   $��4��6�   $��1��6�   $��2��6�   {�.  6�   �� 5@   
   -	   5        $��Quitter��5@      $��Center=�6#   $��Center=�6@   $	��149��6[   $��43��6g   $��5��6s   $��1��6�   $��2��6�   6�   5B      5C      