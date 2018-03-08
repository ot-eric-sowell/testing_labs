const calc = require('./blackjack-calculator.js')

describe('blackjack calculator', () => {
    test('can sum two number cards', () => {
        const cards = ['7', '8']
        const result = calc(cards)
        expect(result).toBe(15)
    })
})
