
mergeInto(LibraryManager.library, {

    XRSession_RequestHitTestSource : function(id, options, callback) {
        var value = _WebIDL2Unity.references[id].requestHitTestSource(_WebIDL2Unity.references[options]);
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(a0){
            Module["dynCall_vii"](callback, promise, _WebIDL2Unity.addReference(a0));
        });

        return promise;
    }
,

    XRSession_RequestHitTestSourceForTransientInput : function(id, options, callback) {
        var value = _WebIDL2Unity.references[id].requestHitTestSourceForTransientInput(_WebIDL2Unity.references[options]);
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(a0){
            Module["dynCall_vii"](callback, promise, _WebIDL2Unity.addReference(a0));
        });

        return promise;
    }

});
