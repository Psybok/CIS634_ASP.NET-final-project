/// <reference path="jquery-1.4.4.js"/>

function vote(voteIcon) {
    var articleId = voteIcon.attr('articleId');
    var isThisAnUpVote = voteIcon.hasClass("up");
    var totalVotesDiv = voteIcon.parent().children(".totalVotes").eq(0);
    var hasVoted, otherVoteIcon, voteValue;

    // Get the other vote icon (e.g., the down vote if the user just clicked up vote
    if (isThisAnUpVote)
        otherVoteIcon = voteIcon.parent().children("div.down").eq(0);
    else
        otherVoteIcon = voteIcon.parent().children("div.up").eq(0);

    // Determine voteValue
    if (isThisAnUpVote) {
        hasVoted = voteIcon.hasClass("upvoted") || otherVoteIcon.hasClass("upvoted");
        voteValue = hasVoted ? 0 : 1;
    }
    else {
        hasVoted = voteIcon.hasClass("downvoted") || otherVoteIcon.hasClass("downvoted");
        voteValue = hasVoted ? 0 : -1;
    }
    // Record our vote!
    $.getJSON('/Vote/?articleId=' + articleId + '&voteValue=' + voteValue,
              function (data) {
                  // Update the article's cumulative vote score
                  totalVotesDiv.html(data.NewVoteScore);
              });

    // Update the display accordingly...
    if (isThisAnUpVote) {
        voteIcon.toggleClass("upvoted");
        otherVoteIcon.removeClass("downvoted");
    }
    else {
        voteIcon.toggleClass("downvoted");
        otherVoteIcon.removeClass("upvoted");
    }
}