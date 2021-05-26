
mergeInto(LibraryManager.library, {

    XRLayerEvent_2 : function(type, eventInitDict) {
        return _WebIDL2Unity.addReference(new XRLayerEvent(Pointer_stringify(type), _WebIDL2Unity.references[eventInitDict]));
    }

});
