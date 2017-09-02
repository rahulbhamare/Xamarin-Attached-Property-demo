Q. What is Attached Property? How to create?
=> An attached property is a special type of bindable property, defined in one class but attached to other objects, and recognizable in XAML as an attribute that contains a class and a property name separated by a period.

Bindable properties should be implemented as attached properties in the following scenarios:
- When there's a need to have a property setting mechanism available for classes other than the defining class.
- When the class represents a service that needs to be easily integrated with other classes.

Creating and Consuming an Attached Property
The process for creating an attached property is as follows:
Create a BindableProperty instance with one of the CreateAttached method overloads.
e.g. 
public static readonly BindableProperty IsAttachedProperty =
  BindableProperty.CreateAttached("IsAttached", typeof(bool), typeof(MainPage),false);

Provide static GetPropertyName and SetPropertyName methods as accessors for the attached property.
The following code example shows accessors for the HasShadow attached property:
public static bool GetIsAttached(BindableObject view)
{
        return (bool)view.GetValue(IsAttachedProperty);
}

public static void SetIsAttached(BindableObject view, bool value)
{
        view.SetValue(IsAttachedProperty, value);
}

Consuming an Attached Property :
1. Add namespace :
<ContentPage ... xmlns:local="clr-namespace:AttachedPropertyDemo" ...>
</ContentPage>
2. <Label x:Name="WelcomeText"            
           local:MainPageViewModel.IsAttached="True"
           VerticalOptions="Center" 
           HorizontalOptions="Center" 
           TextColor="Gray" FontSize="Medium" />
