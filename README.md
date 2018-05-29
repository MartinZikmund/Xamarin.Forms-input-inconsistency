### Description
I have discovered an issue which is quite critical for our business - `CascadeInputTransparent` behaves differently on Android compared to the other platforms.

### Steps to Reproduce

1. Create a XAML page with the following content:

```
<Grid>
    <Grid BackgroundColor="Blue" VerticalOptions="FillAndExpand" HorizontalOptions="FillAndExpand">
        <Grid.GestureRecognizers>
            <TapGestureRecognizer Tapped="TapGestureRecognizer_OnTapped" />
        </Grid.GestureRecognizers>
    </Grid>
    <Grid RowSpacing="0" ColumnSpacing="0" InputTransparent="True" CascadeInputTransparent="False">
        <Grid BackgroundColor="Red" HorizontalOptions="Center" WidthRequest="300" VerticalOptions="Center" HeightRequest="300">
            <Label>Parent - InputTransparent=True, CascadeInputTransparent=False</Label>
        </Grid>
    </Grid>
</Grid>
```
2. In the code-behind add the following `Tapped` event handler:

```
private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
{
	Debug.WriteLine("Tap captured");
}
```

3. Run the app on Android, UWP and iOS 

### Expected Behavior

Tapping the red rectangle should not fire the tapped event handler on the blue `Grid`.

### Actual Behavior

Tapping the red rectangle does not fire tapped event on the blue `Grid` on UWP and iOS, but it does fire on Android. The same goes for all other gestures.

In our project we have a map control instead of a `Grid` this behavior on Android causes that user can manipulate the map over any UI which is above the map, even if it has a solid background, which is not valid.

### Basic Information

- Version with issue: 3.0.0.482510
- Last known good version: -
- IDE: Visual Studio 15.7.2
- Platform Target Frameworks: <!-- All that apply -->
  - iOS:  11.1
  - Android: 8.1
  - UWP: 16299

### Reproduction Link

Repro for the issue is [available here on my GitHub](https://github.com/MartinZikmund/Xamarin.Forms-input-inconsistency).
