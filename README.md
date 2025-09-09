**[View document in Syncfusion Xamarin Knowledge base](https://www.syncfusion.com/kb/12255/how-to-work-with-expandable-multi-level-xamarin-forms-listview-sflistview)**

## Sample

```xaml
<listView:SfListView x:Name="outerListView" ItemsSource="{Binding ContactInfo}" AutoFitMode="DynamicHeight">
    <listView:SfListView.ItemTemplate>
        <DataTemplate>
            <Grid BackgroundColor="#f4f4f2" >
                <Grid.RowDefinitions>
                    <RowDefinition Height="50"/>
                    <RowDefinition Height="*"/>
                </Grid.RowDefinitions>
                <code>
                . . .
                . . .
                <code>
                <listView:SfListView x:Name="innerListView" Margin="5" Grid.Row="1" IsScrollingEnabled="False" IsVisible="{Binding IsInnerListVisible}" ItemsSource="{Binding ContactDetails}" AutoFitMode="DynamicHeight">
                    <listView:SfListView.ItemTemplate>
                        <DataTemplate>
                            <Grid x:Name="grid" RowSpacing="1" BackgroundColor="#bbbfca">
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="70" />
                                    <RowDefinition Height="Auto"/>
                                </Grid.RowDefinitions>
                                <code>
                                . . .
                                . . .
                                <code>
                                <listView:SfListView x:Name="SubListView" IsVisible="{Binding IsSubListVisible}" Margin="5" ItemsSource="{Binding Members}" Grid.Row="1" HeightRequest="{Binding Converter={StaticResource heightConverter}, ConverterParameter={x:Reference SubListView}}" ItemSize="50" BackgroundColor="#f4f4f2">
                                    <listView:SfListView.ItemTemplate>
                                        <DataTemplate>
                                            <Grid Padding="10,0,0,0">
                                                <Label Text="{Binding Name}" VerticalOptions="CenterAndExpand"/>
                                            </Grid>
                                        </DataTemplate>
                                    </listView:SfListView.ItemTemplate>
                                </listView:SfListView>
                            </Grid>
                        </DataTemplate>
                    </listView:SfListView.ItemTemplate>
                </listView:SfListView>
            </Grid>
        </DataTemplate>
    </listView:SfListView.ItemTemplate>
</listView:SfListView>
```