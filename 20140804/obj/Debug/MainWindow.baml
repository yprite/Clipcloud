   M S B A M L   `   `   `  ����C  ?WPFSpark, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:WPFSpark;assembly=WPFSparkWPFSpark  5   	    	Clipcloud   Clipcloud.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   =wpfspark(clr-namespace:WPFSpark;assembly=WPFSpark     5   	   \ XHardcodet.Wpf.TaskbarNotification, Version=1.0.5.0, Culture=neutral, PublicKeyToken=null)tb http://www.hardcodet.net/taskbar  5   	     � Title$  
MainWindow��5   	   $	��350��5   	   $	��525��5   	    � AllowsTransparency .  � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   ��6.   Z�  � 	Resources 5         splashAnimation��%   &	        �� 5   
   6   5       � Triggers 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5      �  J� Opacity$ 0.995Q�6    � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   �� ���	#FF3187A0$
��Left=�6%   $	��349��6@   $��0,1,0,0q�6M   $	��Top=�6^   $	��523��6v   	 �� RadiusX$	 25��6�   
 �� RadiusY$
 26��6�   $��2��6�   �� 5   
   $��1��6   
�������$��0,0,0,0q�5      
������ ._�5!         WPFSpark.FluidProgressBar  $��Stretch=�6(   $��Stretch=�5"   (   
�������   DotWidth$ 6Q�5$   (      	DotHeight$ 6Q�5%   (      
DotRadiusX$ 0Q�5&   (      
DotRadiusY$ 0Q�5'   (      	Oscillate .     TotalDuration$ 00:00:03.25D�5)   (      ReverseDuration$ 00:00:02.15D�5*   (      	KeyFrameA$	 0.3Q�5+   (      	KeyFrameB$	 0.6Q�5,   (      	DurationA$ 00:00:00.25D�5-   (      	DurationB$ 00:00:01.25D�5.   (      	DurationC$ 00:00:00.25D�5/   (      Delay$ 00:00:00.095D�50   (   52      53      �� 5?   
   $��1��6   $��Noto Sans Korean Thin)�5@      
�������$$��copyright all rights resevered��5B      $��Right=�5C      $��Bottom=�5D      $��12(�5E      $��	0,0,20,10q�5F      5G      �� 5H   
   $
��Left=�6   $��54��6+   $��
428,70,0,0q�67   $	��Top=�6K   $��61��6c   $��UniformToFill=�6n   $'��!Resource/image/cloudAdd_white.png��6�   �� 5I   
   $��0��6   $��Noto Sans Korean Thin)�5J   
   
�������$��
Clip Cloud��5L   
   $
��Left=�5M   
   $	��Top=�5N   
   $��82(�5O   
   $��30,80q�5P   
   $��2��6   3  -Hardcodet.Wpf.TaskbarNotification.TaskbarIcon  5R   
   -   5          Name$ MyNotifyIcon��5R         
IconSource$# /Resource/image/Computers.ico��6/      ToolTipText$ hello world��6Z   5S      5U      