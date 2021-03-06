//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnimParamBoolListenerComponent animParamBoolListener { get { return (AnimParamBoolListenerComponent)GetComponent(GameComponentsLookup.AnimParamBoolListener); } }
    public bool hasAnimParamBoolListener { get { return HasComponent(GameComponentsLookup.AnimParamBoolListener); } }

    public void AddAnimParamBoolListener(System.Collections.Generic.List<IAnimParamBoolListener> newValue) {
        var index = GameComponentsLookup.AnimParamBoolListener;
        var component = (AnimParamBoolListenerComponent)CreateComponent(index, typeof(AnimParamBoolListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnimParamBoolListener(System.Collections.Generic.List<IAnimParamBoolListener> newValue) {
        var index = GameComponentsLookup.AnimParamBoolListener;
        var component = (AnimParamBoolListenerComponent)CreateComponent(index, typeof(AnimParamBoolListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnimParamBoolListener() {
        RemoveComponent(GameComponentsLookup.AnimParamBoolListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnimParamBoolListener;

    public static Entitas.IMatcher<GameEntity> AnimParamBoolListener {
        get {
            if (_matcherAnimParamBoolListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnimParamBoolListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnimParamBoolListener = matcher;
            }

            return _matcherAnimParamBoolListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddAnimParamBoolListener(IAnimParamBoolListener value) {
        var listeners = hasAnimParamBoolListener
            ? animParamBoolListener.value
            : new System.Collections.Generic.List<IAnimParamBoolListener>();
        listeners.Add(value);
        ReplaceAnimParamBoolListener(listeners);
    }

    public void RemoveAnimParamBoolListener(IAnimParamBoolListener value, bool removeComponentWhenEmpty = true) {
        var listeners = animParamBoolListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnimParamBoolListener();
        } else {
            ReplaceAnimParamBoolListener(listeners);
        }
    }
}
