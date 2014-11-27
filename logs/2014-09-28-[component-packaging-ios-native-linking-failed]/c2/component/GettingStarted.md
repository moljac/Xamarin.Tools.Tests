## Applying the Theme

To style your app with this theme, call
`PodradioTheme.Apply` from your AppDelegate's `FinishedLaunching` method:

```csharp
using Xamarin.Themes;
...

public override bool FinishedLaunching (UIApplication app, NSDictionary options)
{
	...
	PodradioTheme.Apply ();
}
```

You can also selectively apply the theme to specific views. To apply the
theme to views of a specific class, call `Apply` with the `Appearance`
value for the class you'd like to theme:

```csharp
PodradioTheme.Apply (UIProgressView.Appearance);
```

To apply the theme to specific view classes only when they are contained
within other specific view classes, use `AppearanceWhenContainedIn`. In
the following example, we apply `PodradioTheme` to `UIProgressView` only
when `UIProgressView` is a child of `UINavigationBar`:

```csharp
PodradioTheme.Apply (UIProgressView.AppearanceWhenContainedIn (typeof (UINavigationBar)));
```

Finally, to apply the theme to a specific view instance:

```csharp
UITableView tableView;
...

PodradioTheme.Apply (tableView);
```

When applying a theme to a TableView, you still need to apply the theme to the cells.

```csharp
public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
{
	UITableViewCell cell;
	...
	PodradioTheme.Apply (cell);
	return cell;
}
```

Applying the theme to specific view instances is especially useful for `UIButton`,
`UILabel`, and `UIView`, since these classes are not themed automatically when
calling the parameterless version of `Apply`.