   M S B A M L   `   `   `  ����C  ?WPFSpark, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:WPFSpark;assembly=WPFSparkWPFSpark  5   	    	Clipcloud   Clipcloud.LoadingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   =wpfspark(clr-namespace:WPFSpark;assembly=WPFSpark     5   	     � Title$  
MainWindow��5   	   $	��350��5   	   $	��525��5   	    � AllowsTransparency .  � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   ��6.   Z�  � 	Resources 5         splashAnimation  BoundAnimation �� TargetProperty �� 
TargetName W� From	 W� To	 g� AutoReverse
 g� RepeatBehavior g� FillBehavior g� Duration��%�   &	        &	      �� 5   
   6   �� 5   
   .��5      W� $ (FrameworkElement.Height)�6   $ image��5      $ 64X�5      $ 74X�5      	 . $
 2��5      $ HoldEnd=�5      $ 00:00:3D�5      5      5      5        � Triggers 5!      :� 5"   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5#      �� #��[  6   �� 5$      #��[ 6   5%      .��5'      �  J� Opacity$ 0.995Q�6    � RowDefinitions 5)   
   �� 5*      6   �� 5+      6   .+�5.   
   �� ���	#FF3187A0$
��Left=�6%   $	��349��6@   $��0,1,0,0q�6M   $	��Top=�6^   $	��523��6v    �� RadiusX$ 25��6�    �� RadiusY$ 26��6�   $��2��6�   �� 5/   
   $��1��6   
�������$��0,0,0,0q�51      
������ ._�53         WPFSpark.FluidProgressBar  $��Stretch=�6(   $��Stretch=�54   (   
�������   DotWidth$ 7Q�56   (      	DotHeight$ 7Q�57   (      
DotRadiusX$ 1Q�58   (      
DotRadiusY$ 1Q�59   (      	Oscillate .     TotalDuration$ 00:00:03.25D�5;   (      ReverseDuration$ 00:00:02.15D�5<   (      	KeyFrameA$	 0.3Q�5=   (      	KeyFrameB$	 0.6Q�5>   (      	DurationA$ 00:00:00.25D�5?   (      	DurationB$ 00:00:01.25D�5@   (      	DurationC$ 00:00:00.25D�5A   (      Delay$ 00:00:00.095D�5B   (   5D      5E      �� 5Q   
   $��1��6   $��Noto Sans Korean Thin)�5R      
�������$$��copyright all rights resevered��5T      $��Right=�5U      $��Bottom=�5V      $��12(�5W      $��	0,0,20,10q�5X      5Y      �� 5\   
   $��0��6   $��Noto Sans Korean Thin)�5]   
   
�������$��
Clip Cloud��5_   
   $
��Left=�5`   
   $	��Top=�5a   
   $��82(�5b   
   $��30,80q�5c   
   $��2��5d      �� 5e   
   -   5          ��Name$  image��5e      $
��Left=�6   $��74��6:   $��
416,77,0,0q�6F   $	��Top=�6Z   $��74��6r   $��Uniform=�6}   $'��!Resource/image/cloudAdd_white.png��6�   $��0��6�   ! J� RenderTransformOrigin$! 0.5,0.5&�6�   5i      5k      