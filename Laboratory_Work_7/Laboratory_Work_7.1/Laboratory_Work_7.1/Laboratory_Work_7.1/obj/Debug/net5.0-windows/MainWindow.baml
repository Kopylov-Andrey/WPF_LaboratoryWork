   M S B A M L   `   `   `  ����N  JLaboratory_Work_7.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Laboratory_Work_7._1Laboratory_Work_7._1  5   	   %    Laboratory_Work_7._1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Laboratory_Work_7._1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      (  "Laboratory_Work_7._1.DateConverter   key2��%   &	          5
   
   6   5      .��5      �� .+�5   
   (  "System.Windows.Controls.DatePicker  -   5        $��DP��5      $	��150��6   
 �� Top$	 200��6+    �� Left$ 20��6<      SelectedDate 5      `� 5       `� 	Converter# [  6    `� UpdateSourceTrigger$ PropertyChanged=�6A   .1�5      ��  �� ElementName$	 TB1��6    �� Path$
 Text�60   6>   �� 5      $	 TB2��6   $
 Text�60   6>   �� 5      $	 TB3��6   $
 Text�60   6>   5      5      �� 5   
   -   5        $	��TB1��5      $	��150��6   $ 10��6)   $ 20��69   �� 5   
   -   5        $	��TB2��5      $	��150��6   $ 70��6)   $ 20��69   �� 5   
   -   5        $	��TB3��5      $	��150��6   $	 140��6)   $ 20��6:   5      5      