
mergeInto(LibraryManager.library, {
    WebIDL2UnityGetElementAtNative_Uint8Array : function(id, index){
        return _WebIDL2Unity.references[id][index];
    },

    WebIDL2UnitySpliceNative_Uint8Array_3 : function(id, start, deleteCount, item){
            _WebIDL2Unity.references[id].splice(start, deleteCount, item);
    },
    WebIDL2UnitySpliceNative_Uint8Array_2 : function(id, start, deleteCount){
            _WebIDL2Unity.references[id].splice(start, deleteCount);
    },

    WebIDL2UnityIndexOfNative_Uint8Array : function(id, item){
        return _WebIDL2Unity.references[id].indexOf(item);
    }
});