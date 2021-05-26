
mergeInto(LibraryManager.library, {
    WebIDL2Unity_XRDOMOverlayType_get : function(parentID, fieldName){
       return _WebIDL2UnityEnums.XRDOMOverlayType[_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]];
    },
    WebIDL2Unity_XRDOMOverlayType_set : function(parentID, fieldName, value){
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = _WebIDL2UnityEnums.XRDOMOverlayType[value];
    }
});
