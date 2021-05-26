
mergeInto(LibraryManager.library, {

    XRInputSourceEvent_2 : function(type, eventInitDict) {
        return _WebIDL2Unity.addReference(new XRInputSourceEvent(Pointer_stringify(type), _WebIDL2Unity.references[eventInitDict]));
    }

});
