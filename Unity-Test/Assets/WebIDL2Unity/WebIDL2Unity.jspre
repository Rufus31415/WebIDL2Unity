
_WebIDL2Unity = {
    next: 1,
    references: { 0: null },
    addReference: function (obj) {
        if (obj==null) {
            return 0;
        }
        else {
            var id = this.next;
            this.references[id] = obj;
            this.next++;
            return id;
        }
    },
    deleteReference: function (id) {
        console.log("Delete object : ");
        console.log(id);
        if (id !== 0) delete this.references[id];
    }
}