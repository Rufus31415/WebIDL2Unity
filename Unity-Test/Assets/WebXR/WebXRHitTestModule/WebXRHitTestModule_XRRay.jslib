
mergeInto(LibraryManager.library, {

    XRRay_2 : function(origin, direction) {
        return _WebIDL2Unity.addReference(new XRRay(_WebIDL2Unity.references[origin], _WebIDL2Unity.references[direction]));
    }
,

    XRRay_1 : function(transform) {
        return _WebIDL2Unity.addReference(new XRRay(_WebIDL2Unity.references[transform]));
    }

});
