
mergeInto(LibraryManager.library, {

    XRSession_RequestLightProbe : function(id, options) {
        var value = _WebIDL2Unity.references[id].requestLightProbe(_WebIDL2Unity.references[options]);
        return 
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){
            Module["dynCall_iiii"](callback, promise, supported)
        });

        return promise;
;
    }

});
