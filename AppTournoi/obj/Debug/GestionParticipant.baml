   M S B A M L   `   `   `  ����E  AAppTournoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AppTournoi
AppTournoi  5   	   #    AppTournoi.GestionParticipant   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AppTournoi     5   	     � Title$-  'Gestion des Participants (Gestionnaire)��5      $	��450��6=   $	��800��6J   $	��450��5	   	   $	��800��6   .��5
      � ���#d7ecee � RowDefinitions 5   
   �� 5      $	��26* �6   �� 5      $��5* �6    � ColumnDefinitions 5   
   �� 5      $
��120* �6   �� 5      $
��267* �6   �� 5      $
��267* �6   �� 5      $
��120* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$! DataGridParticipantsGestion��5         AutoGenerateColumns .  $��15,15,15,15q�6   $��4��6�      
IsReadOnly .    SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�    � ContextMenu 5      �� 5      -   5        $ ��ContextMenuListParticipant��5      .@�5      m� -   5        $%��MenuContextSupprimerParticipant��5      $��Supprimer un Participant��6F   6h   m� 5      -   5        $$��MenuContextModifierParticipant��5      $��Modifier un Participant��6E   6f   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 Nom��6%      CanUserSort . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Nom+6J     5      $
 Prenom��6%    .  65   �� *Prenom+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5       $
 Photo��6)      CellTemplate 5!      �� 5"      .R�5#      �� $	��100��6=   ��6$   �� *Photo+6=   5$      5&        5(      $

 Sexe��6%    .   63   �� *Sexe+6L     5)      $
 Date de naissance��6%    .   6@   �� *DateNaissance+ �� StringFormat$ d��6s     5*      $
 
Id Tournoi��6%    .   69   �� *	Tournoi+6U   5-      �� 5/   
   -   5        $��Ajouter un participant��5/      $	��149��62   $��43��6>   $��Center=�6J   $��Center=�6e   $��1��6�   $��1��6�   �� 50   
   -   5        $��Quitter��50      $	��150��6#   $��43��6/   $��Center=�6;   $��Center=�6V   $��2��6�   $��1��6�   53      54      