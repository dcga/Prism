﻿using Prism.Properties;

namespace Prism.Navigation.Regions;

/// <summary>
/// Region that keeps all the views in it as active. Deactivation of views is not allowed.
/// </summary>
public class AllActiveRegion : Region
{
    /// <summary>
    /// Creates a new <see cref="AllActiveRegion"/>.
    /// </summary>
    /// <param name="regionNavigationService"></param>
    public AllActiveRegion(IRegionNavigationService regionNavigationService)
        : base(regionNavigationService)
    {
    }

    /// <summary>
    /// Gets a readonly view of the collection of all the active views in the region. These are all the added views.
    /// </summary>
    /// <value>An <see cref="IViewsCollection"/> of all the active views.</value>
    public override IViewsCollection ActiveViews => Views;

    /// <summary>
    /// Deactivate is not valid in this Region. This method will always throw <see cref="InvalidOperationException"/>.
    /// </summary>
    /// <param name="view">The view to deactivate.</param>
    /// <exception cref="InvalidOperationException">Every time this method is called.</exception>
    public override void Deactivate(object view)
    {
        throw new InvalidOperationException(Resources.DeactiveNotPossibleException);
    }
}
