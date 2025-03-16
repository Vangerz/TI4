﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TI4_GameEngine.Objects;

namespace GameUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        SetupImage();
    }

    public void SetupImage()
    {
        //Test Card object
        Card leadership = new Card(StrategyTypes.LEADERSHIP);
        Card diplomacy = new Card(StrategyTypes.DIPLOMACY);
        Card politics = new Card(StrategyTypes.POLITICS);
        Card construction = new Card(StrategyTypes.CONSTRUCTION);
        Card trade = new Card(StrategyTypes.TRADE);
        Card warfare = new Card(StrategyTypes.WARFARE);
        Card technology = new Card(StrategyTypes.TECHNOLOGY);
        Card imperial = new Card(StrategyTypes.IMPERIAL);

        // Set the image source.
        Card1.Source = leadership.FrontOfCard();
        Card2.Source = diplomacy.FrontOfCard();
        Card3.Source = politics.FrontOfCard();
        Card4.Source = construction.FrontOfCard();
        Card5.Source = trade.FrontOfCard();
        Card6.Source = warfare.FrontOfCard();
        Card7.Source = technology.FrontOfCard();
        Card8.Source = imperial.FrontOfCard();

    }
}