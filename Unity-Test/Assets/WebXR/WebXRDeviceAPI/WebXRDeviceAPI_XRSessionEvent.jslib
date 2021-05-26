
mergeInto(LibraryManager.library, {

    XRSessionEvent_2 : function(type, eventInitDict) {
        return _WebIDL2Unity.addReference(new XRSessionEvent(Pointer_stringify(type), _WebIDL2Unity.references[eventInitDict]));
    }

});
