   M S B A M L   `   `   `  ����E  AAppTournoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AppTournoi
AppTournoi  5   	        AppTournoi.ListParticipant   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AppTournoi     5   	     � Title$  Liste des participants��5   	   $	��450��6(   $	��800��65   .��5	      � ���#d7ecee$��	0,0,-33,0q�6     � RowDefinitions 5
   
   �� 5      $
��119* �6   �� 5      $	��73* �6   �� 5      $	��56* �6   �� 5      $
��186* �6    � ColumnDefinitions 5   
   �� 5      $
��633* �6   �� 5      $
��174* �6   �� 5      $	��26* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridParticipants��5         AutoGenerateColumns .  $��23,30,18,38q�6x   $��4��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      CanUserSort .    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   �� *Id+6\     5      $	 Nom��6%    .  . 	 62   �� *Nom+6]     5      $ Prenom��6%    .  . 	 65   �� *Prenom+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Photo��6)    . 
   CellTemplate
 5      �� 5      .R�5       �� $	��100��6=   ��6$   �� *Photo+6=   5!      5#        5%      $
 Sexe��6%    .   . 	 63   �� *Sexe+6`     5&      $ Date de naissance��6%    .   . 	 6@   �� *DateNaissance+ �� StringFormat$ d��6�     5'      $ 
Id Tournoi��6%    .   . 	 69   �� *	Tournoi+6i   5*      �� 5,   
   $��1��6   $��Nom du Participant : ��6     J� RenderTransformOrigin$ 0.494,-0.518&�6@   $��1��6e   $��26��6r   $��Bottom=�6~   $��Center=�6�   $��0,0,0,23q�6�   �� 5-   
   -   5         ��Name$ tbRecherche��5-      $��1��6'   $��2��67    �� TextWrapping$
 Wrap=�6D   $�� ��6X   $��10,10,17,19q�6`   6u   5.      5/      