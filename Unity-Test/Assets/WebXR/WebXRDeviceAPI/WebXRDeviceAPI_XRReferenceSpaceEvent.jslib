
mergeInto(LibraryManager.library, {

    XRReferenceSpaceEvent_2 : function(type, eventInitDict) {
        return _WebIDL2Unity.addReference(new XRReferenceSpaceEvent(Pointer_stringify(type), _WebIDL2Unity.references[eventInitDict]));
    }

});
