
mergeInto(LibraryManager.library, {

    XRInputSourcesChangeEvent_2 : function(type, eventInitDict) {
        return _WebIDL2Unity.addReference(new XRInputSourcesChangeEvent(Pointer_stringify(type), _WebIDL2Unity.references[eventInitDict]));
    }

});
