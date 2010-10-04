JSpec.describe('Grammar-less', function() {

    it('should be able to pass a unit test', function () {
        expect(true).to(be, true)
    })

    it('should be able to fail a unit test', function () {
        expect(true).to(be, false)
    })
  
})