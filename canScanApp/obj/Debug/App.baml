   M S B A M L   `   `   `  ����E  AcanScanApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:canScanApp
canScanApp  5          canScanApp.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      *localclr-namespace:canScanApp     5        �� 	Resources  5         WindowColor  ContentAreaColorLight  ContentAreaColorDark  DisabledControlLightColor  DisabledControlDarkColor  DisabledForegroundColor  SelectedBackgroundColor  SelectedUnfocusedColor  ControlLightColor 	 ControlMediumColor 
 ControlDarkColor  ControlMouseOverColor  ControlPressedColor  
GlyphColor  GlyphMouseOver  BorderLightColor  BorderMediumColor  BorderDarkColor  PressedBorderLightColor  PressedBorderDarkColor  DisabledBorderLightColor  DisabledBorderDarkColor  DefaultBorderBrushDarkColor  HeaderTopColor " DatagridCurrentCellBorderColor  SliderTrackDarkColor  NavButtonFrameColor  MenuPopupBrush �� EndPoint �� 
StartPoint � Color � Offset  FontAwesome  RoundButtonTemplate �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius  ComboBoxToggleButton
 � ColumnDefinitions'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ��Name �� Color F�Name  ComboBoxTextBox R� KeyTime  System.Windows.Visibility   Visible R� Value   Hidden d�Name �� 	ClickMode d� 	IsChecked �� Mode �� RelativeSource ��Name J� IsHitTestVisible  �� SelectionBoxItem! �� SelectionBoxItemTemplate" ��Name# �� 
IsReadOnly$ �� 
IsReadOnly% �Name& �� IsDropDownOpen' � AllowsTransparency( �Name) J� SnapsToDevicePixels* � ActualWidth+ �� MaxDropDownHeight, K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation-   DirectionalNavigation. �� Triggers/ P� Property0 P� Value1 �� 
TargetName2 P� 
SourceName3 �� Padding   TextBoxStyleRound4 ��Name5 �� Triggers6 ]� 
Conditions7 �� Property8 �� Value��%�!  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     &	 �     &	     &		 #    &	
 B    &	 a    &	 �    &	 �    &	 �    &	 �    &	 "    &	 C    &	 f    &	 �    &	 �    &	 �    &	 �    &	     &	 .    &	 Q    &	 r    &	 �    &	 Z    &	 �    &	     7  7  7  7  7  &	 �    '�� �    7  7  '�� �    7  7  &	      ��5   
   	#FFE8EDF9��6/   ��5   
   	#FFC5CBF9��69   ��5	   
   	#FF7381F9��68   ��5   
   	#FFE8EDF9��6=   ��5   
   	#FFC5CBF9��6<   ��5   
   #6f58a1��69   ��5   
   #6f58a1��69   ��5   
   	#FFDDDDDD��6:   ��5   
   #433C72��63   ��5   
   #433C72��64   ��5   
   #433C72��62   ��5   
   #6f58a1��67   ��5   
   #503b7d��65   ��5   
   	White��6*   ��5   
   /+sc#1, 0.004391443, 0.002428215, 0.242281124��6T   ��5   
   Transparent��66   ��5   
   	#FF444444��65   ��5    
   Transparent��65   ��5"   
   	#FF888888��6;   ��5#   
   	#FF444444��6:   ��5%   
   	#FFAAAAAA��6<   ��5&   
   	#FF888888��6;   ��5(   
   Transparent��6A   ��5+   
   	#FFC5CBF9��62   ��5,   
   Transparent��6D   ��5-   
   	#FFC5CBF9��68   ��5/   
   	#FF3843C4��67   �� 51   
   $ 0.5,1&�52      $ 0.5,0&�53      .��54      � # �  6   $ 0Q�55      � 56      # � 	 6   $	 0.5Q�57      � 58      # �  6   $ 1Q�59      5:      *�5<   
   -)/Fonts/fontawesome-webfont.tt#FontAwesome)�6T   �� 5=   
   " ��6,   .�5>      ��  � �� �#433C726+   �� 5?       � ��
 �����6+   �� 5@       � ��$ 20(�6)   �� 5A       � �� 5B      �� 5C      " ��6&   .R�5D      �� $	 10��6!   #��z��63   $��0q�6]   ._�5E      �� $
��Left=�6/   $��Center=�6J   $
��20,0q�6e   5F      5G      5H      5J      5K      �� 5M   
   " d�5N      .R�5O      � 
 5P      �� 5Q      �� 5R      $��20 �6'    5T        5U      CommonStates��. 5V        
Normal��6&     5W      	MouseOver��. 5X      �� .��5Y   "   �� $_ Y(Panel.Background).                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�6?   $ Border��5[   +   .g�5\   &     $ 0��6:   8   5]   $   5^   #   5_      5`        5a      Pressed��6&     5b      Disabled��. 5c      �� .��5d   "   �� $_ Y(Panel.Background).                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�6?   $ Border��5f   +   .g�5g   &     $ 0��6:   8  5h   $   5i   #   �� 5j   "   $; 5(Shape.Fill).                 (SolidColorBrush.Color)�6?   $ Arrow��5l   +   .g�5m   &     $ 0��6:   8  5n   $   5o   #   �� 5p   "   $a [(Border.BorderBrush).                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�6?   $ Border��5r   +   .g�5s   &     $ 0��6:   8  5t   $   5u   #   5v      5w      5x        5y      CheckStates��. 5z        Checked��. 5{      �� .��5|   "   �� $_ Y(Panel.Background).                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�6?   $ Border��5~   +   .g�5   &     $ 0��6:   8  5�   $   5�   #   5�      5�        5�      	Unchecked��6&     5�      Indeterminate��6&   5�      .+�5�      �� $ Border��6   $��2��5�      $	 10��5�      $��1q�5�      ��5�      �� 5�      $	 0,1&�6.   $	 0,0&�5�      .��5�      � # �  6+   $ 0Q�5�      � 5�      # �  6+   $ 1Q�5�      5�      ��5�      �� 5�      $	 0,0&�6.   $	 0,1&�5�      ��5�   "   � � 5�   &   # �  63   � 5�   &   # � 	 63   $	 1.0Q�5�      5�   #   5�      5�      �� 5�      $��0��6   $	 	10 0 0 10��5�      $��1q�5�      ��5�      �� 5�      # �  6*   5�      F� 5�      $ Arrow��6   $��1��5�      $��Center=�5�      $��Center=�5�      "����        � 	=  	= � z     	��5�      �� 5�      # �  6*   5�      5�      5�      �� 5�   
   " ��5�      .R�5�      �� $ PART_ContentHost��6   |�.  #��z��5�      5�      �� 5�   
   " ��5�      .�5�      ��  �@J�SnapsToDevicePixels . 5�      �� 5�       �@�OverridesDefaultStyle . 5�      �� 5�       � ��$
 Auto=�5�      �� 5�       � ��$
 Auto=�5�      �� 5�       � �� . 5�      �� 5�       � ��$	 120��5�      �� 5�       � ��$ 20��5�      �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �  5�        5�   "   CommonStates��. 5�   &     
Normal��62     5�   &   	MouseOver��62   5�   #     5�   "   
EditStates��. 5�   &     Editable��. 5�   *   �� .��5�   .   T� $ (UIElement.Visibility)�6L   $ PART_EditableTextBox��5�   2   ..�5�   2   i� $ 0��6I   # Z 5�   -   5�   /   T� 5�   .   $ (UIElement.Visibility)�5�      $ ContentSite��5�   2   ..�5�   2   i� $ 0��6I   # Z 5�   -   5�   /   5�   +   5�   '     5�   &   
Uneditable��62   5�   #   .+�5�      d� $ ToggleButton��6+   8��  $��2��5�      |�.  $ Press=�5�       5�      �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+�� 5�      $ ContentSite��6/    .  
�������$��16(�5�   /   #��z  5�      #��z! 5�      #��z��5�      $��10q�5�      $��Stretch=�5�      $
��Left=�5�      5�      �� 5�      $" PART_EditableTextBox��6&   8�� $
��Left=�5�   &   $��Bottom=�5�   &   $��10q�5   &   |�. 
�������$��16(�5  &   
������ $y�Visible=�5  &   #$ z# 5  &   ��5�   &   Z� 5  &   � 5     $% Popup��6$   $��Bottom=�5     #��z& 5	     ' . |�.  $��Slide=�5     .��5  "   � $( DropDown��6'   ) . #��z* 5     #��z+ 5     .+�5  &   �� $ DropDownBorder��6-   $��1q�5     ��5  *   �� 5  .   # �  6>   ��5  *   �� 5  .   $ White��6>   5  '   �� 5  &   $��4,6,4,6q�63   ) . .��5  *   �� , . $- 	Contained=�5     5  '   5  #   5      5!     . 5"     P� 5#     / �@��HasItems0 .  . �5%  "   �� $1 DropDownBorder��6)    � ��$ 95��5'     5(     P� 5)     / �@��
IsGrouping0 . . �5+  "   ��  � �� .  5,     5-     P� 5.     $2 Popup��6&   / �@�AllowsTransparency0 . . �51  "   �� $1 DropDownBorder��6)    �@��CornerRadius$ 4��53     �� 54  "   $1 DropDownBorder��6)    � ��$ 0,2,0,0q�56     57     59     5;     5<     �� 5>  
   " ��5?     .�5@     ��  �@J�SnapsToDevicePixels . 5A     �� 5B      �@�OverridesDefaultStyle . 5C     �� 5D      � �� 5E     �� 5F     " ��6&   .R�5G     �� $ Border��6!   $3 0q�5H  !   ) . 
������� 5K       5L  "   SelectionStates��. 5M  &     
Unselected��62     5N  &   Selected��. 5O  *   �� .��5P  .   �� $ Border��6K   $0 *(Panel.Background).(SolidColorBrush.Color)�5Q  1   .g�5R  2     $ 0��6F   8   5S  *   5T  /   5U  +   5V  '     5W  &   SelectedUnfocused��. 5X  *   �� .��5Y  .   �� $ Border��6K   $E ?(Panel.Background).                     (SolidColorBrush.Color)�5Z  1   .g�5\  2     $ 0��6F   8  5]  *   5^  /   5_  +   5`  '   5a  #   ._�5c     �� 5d     5e     5g     5h     �� 5j  
   " ��6*   .�5k     ��  � ��# � ��6+   �� 5l      � ��# � ��6+   �� 5m      � ��$ 1q�60   �� 5n      �@ TabNavigation$
 None=�6A   �� 5o      � ��$
 Left=�6;   �� 5p      �@�FocusVisualStyle 61   Z� �� 5q      �@J�	AllowDrop . 6*   �� 5r      �@��PanningMode$ VerticalFirst=�69   �� 5s      �@��IsFlicksEnabled .  67   �� 5t      � �� 5u     �� 5v     " ��6&   .R�5w     �� $ border��5x     #��z��5y     #��z��5z     #��z��5{     $	 6��5|     ) . ._�5~     �� $4 PART_ContentHost��5  !   |�.  $��Hidden=�5�  !   $��Hidden=�5�  !   5�     . 5�     P� 5�     / � {�0 .  . �5�  "   �� $1 border��6)    �@J�Opacity$
 0.56Q�6P   5�     5�     5�     5 5�     ]� 5�     6 5�     �� 5�     +7 �@��#IsInactiveSelectionHighlightEnabled8 . 6S   �� 5�     7 �@��IsSelectionActive8 .  6A   ./�5�     ��  �@��SelectionBrush# � /�67   5�     5�     5�     5�     