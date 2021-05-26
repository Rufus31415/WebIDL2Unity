
mergeInto(LibraryManager.library, {

    XRSession_RequestHitTestSource : function(id, options) {
        var value = _WebIDL2Unity.references[id].requestHitTestSource(_WebIDL2Unity.references[options]);
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }
,

    XRSession_RequestHitTestSourceForTransientInput : function(id, options) {
        var value = _WebIDL2Unity.references[id].requestHitTestSourceForTransientInput(_WebIDL2Unity.references[options]);
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }

});
