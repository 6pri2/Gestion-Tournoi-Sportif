   M S B A M L   `   `   `  ����E  AAppTournoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AppTournoi
AppTournoi  5   	   $    AppTournoi.GestionGestionnaire   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AppTournoi     5   	     � Title$-  'Gestion des Gestionnaire (Gestionnaire)��5   	   $	��450��69   $	��800��6F   $	��450��5	   	   $	��800��6   .��5
      � ���#d7ecee � ColumnDefinitions 5   
   �� 5      $
��121* �6   �� 5      $	��39* �6   �� 5      $	��39* �6    � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ lvGestionnaireGestion��5      $��15,15,15,15q�62   $��7��6G    � ContextMenu 5      �� 5      -   5        $��ContextMenuListTournoi��5      .@�5      m� -   5        $&�� MenuContextSupprimerGestionnaire��5      $��Supprimer un gestionnaire��6G   6j   m� 5      -   5        $%��MenuContextModifierGestionnaire��5      $��Modifier un gestionnaire��6F   6h   5       ��5"      �� 5#      .R�5$      �� �� 5%      
���   ��6   �� *Login+65   5&      5'      5)      �� 5+   
   -   5        $!��Deconnexion du gestionnaire��5+      $	��160��67   $��30��6C   $��10,10,10,10q�6O   $	��Top=�6d   $��Right=�6|   $��1��6�   $��2��6�   6�   �� 5-   
   -   5         ��Name$
 text��5-   5   $ ��Ajouter un Gestionnaire : ��6   
���   �$��Center=�6V   $��Center=�6q   $��1��6�   $��1��6�   $��2��6�   �� 5/   
   $��Login : ��6   
���   �$��Center=�66   $��Center=�6Q   $��1��6n   $��2��6~   �� 50   
   -   5         ��Name$ tbLogin��50      ���#bdcdca$��10,10,10,10q�68   $��2��6M   $��2��6]   6j   �� 52   
   $��Mot de Passe : ��6   
���   �$��Center=�6=   $��Center=�6X   $��1��6u   $��3��6�   G� 53   
   -   5         G�Name$ tbMDP��53      ���#bdcdca$��10,10,10,10q�6:   $��2��6O   $��3��6_   6l   �� 55   
   $#��Vérification Mot de Passe : ��6   
���   �$��Center=�6J   $��Center=�6e   $��1��6�   $��4��6�   G� 56   
   -	   5        $ 
tbVerifMDP��56      ���#bdcdca$��10,10,10,10q�6?   $��2��6T   $��4��6d   6q   �� 58   
   -
   5         ��Name$ ButtonAjouterGestionnaire��58      $��Ajouter le gestionnaire��64   $	��149��6V   $��43��6b   $��Center=�6n   $��Center=�6�   $��1��6�   $��5��6�   $��2��6�   {�.  6�   �� 59   
   -   5        $��Quitter��59      $	��149��6#   $��43��6/   $��Center=�6;   $��Center=�6V   $��1��6�   $��6��6�   $��2��6�   5;      5<      